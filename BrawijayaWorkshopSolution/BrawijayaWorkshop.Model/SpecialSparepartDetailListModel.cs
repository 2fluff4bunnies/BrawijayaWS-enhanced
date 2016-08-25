using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SpecialSparepartDetailListModel : AppBaseModel
    {
        private ISpecialSparepartRepository _specialSparepartRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IUnitOfWork _unitOfWork;

        public SpecialSparepartDetailListModel(ISpecialSparepartRepository WheelRepository,
            ISpecialSparepartDetailRepository WheelDetailRepository,
            ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _specialSparepartRepository = WheelRepository;
            _specialSparepartDetailRepository = WheelDetailRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _sparepartRepository = sparepartRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SpecialSparepartDetailViewModel> SearchDetail(int specialSparepartId,
            DbConstant.WheelDetailStatus status)
        {
            List<SpecialSparepartDetail> result = _specialSparepartDetailRepository.GetMany(whd => whd.Status == (int)status
                && whd.SpecialSparepartId == specialSparepartId).ToList();

            List<SpecialSparepartDetailViewModel> mappedResult = new List<SpecialSparepartDetailViewModel>();
            return Map(result, mappedResult);
        }


        public void RemoveSpecialSparepart(int specialSparepartDetailId, int userId)
        {
            DateTime serverTime = DateTime.Now;

            SpecialSparepartDetail sspdEntity = _specialSparepartDetailRepository.GetById(specialSparepartDetailId);
            sspdEntity.ModifyDate = serverTime;
            sspdEntity.ModifyUserId = userId;
            sspdEntity.Status = (int)DbConstant.WheelDetailStatus.Deleted;

            _specialSparepartDetailRepository.AttachNavigation(sspdEntity.SpecialSparepart);
            _specialSparepartDetailRepository.AttachNavigation(sspdEntity.SparepartDetail);
            _specialSparepartDetailRepository.AttachNavigation(sspdEntity.CreateUser);
            _specialSparepartDetailRepository.AttachNavigation(sspdEntity.ModifyUser);
            _specialSparepartDetailRepository.Update(sspdEntity);
            _unitOfWork.SaveChanges();

            SparepartDetail spdEntity = _sparepartDetailRepository.GetById(sspdEntity.SparepartDetailId);
            spdEntity.ModifyDate = serverTime;
            spdEntity.ModifyUserId = userId;
            spdEntity.Status = (int)DbConstant.SparepartDetailDataStatus.Deleted;

            _sparepartDetailRepository.AttachNavigation(spdEntity.Sparepart);
            _sparepartDetailRepository.AttachNavigation(spdEntity.SparepartManualTransaction);
            _sparepartDetailRepository.AttachNavigation(spdEntity.PurchasingDetail);
            _sparepartDetailRepository.AttachNavigation(spdEntity.CreateUser);
            _sparepartDetailRepository.AttachNavigation(spdEntity.ModifyUser);
            _sparepartDetailRepository.Update(spdEntity);
            _unitOfWork.SaveChanges();

            Sparepart spEntity = _sparepartRepository.GetById(spdEntity.SparepartId);
            spEntity.ModifyDate = serverTime;
            spEntity.ModifyUserId = userId;

            if (spEntity.StockQty > 0)
            {
                spEntity.StockQty = spEntity.StockQty - 1;
            }

            _sparepartRepository.AttachNavigation(spEntity.UnitReference);
            _sparepartRepository.AttachNavigation(spEntity.CategoryReference);
            _sparepartRepository.AttachNavigation(spEntity.CreateUser);
            _sparepartRepository.AttachNavigation(spEntity.ModifyUser);
            _sparepartRepository.Update(spEntity);
            _unitOfWork.SaveChanges();
        }

        public bool IsSpecialSparepartDetailInstalled(int specialSparepartDetailId)
        {
            bool result = false;

            SpecialSparepartDetail sspdEntity = _specialSparepartDetailRepository.GetById(specialSparepartDetailId);

            if (sspdEntity.Status == (int)DbConstant.WheelDetailStatus.Installed)
                result = true;

            return result;
        }
    }
}
