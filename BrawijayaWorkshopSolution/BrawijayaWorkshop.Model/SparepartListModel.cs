using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Model
{
    public class SparepartListModel : AppBaseModel
    {
        private ISparepartRepository _sparepartRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private ISparepartStockCardRepository _sparepartStockCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStockCardDetailRepository;
        private ISparepartManualTransactionRepository _sparepartManualTransactionRepository;
        private IUnitOfWork _unitOfWork;

        public SparepartListModel(ISparepartRepository sparepartRepository,
            ISpecialSparepartDetailRepository specialSparepartDetailRepository,
            IReferenceRepository referenceRepository,
            ISparepartStockCardRepository sparepartStockCardRepository,
            ISparepartStockCardDetailRepository sparepartStockCardDetailRepository,
            ISparepartManualTransactionRepository sparepartManualTransactionRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _sparepartRepository = sparepartRepository;
            _specialSparepartDetailRepository = specialSparepartDetailRepository;
            _referenceRepository = referenceRepository;
            _sparepartStockCardRepository = sparepartStockCardRepository;
            _sparepartStockCardDetailRepository = sparepartStockCardDetailRepository;
            _sparepartManualTransactionRepository = sparepartManualTransactionRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReferenceViewModel> GetSparepartCategoryList()
        {
            Reference sparePartCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPAREPARTCATEGORY, true) == 0).FirstOrDefault();
            List<Reference> result = _referenceRepository.GetMany(r => r.ParentId == sparePartCategory.Id).ToList();
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(result, mappedResult);
        }

        public List<SparepartViewModel> SearchSparepart(int categoryReferenceId, string name)
        {
            List<Sparepart> result = null;

            if (categoryReferenceId > 0)
            {
                result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.DefaultDataStatus.Active &&
                    sp.CategoryReferenceId == categoryReferenceId && sp.Name.Contains(name)).ToList();
            }
            else
            {
                result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.DefaultDataStatus.Active && sp.Name.Contains(name)).ToList();
            }

            List<SparepartViewModel> mappedResult = new List<SparepartViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteSparepart(SparepartViewModel sparepart, int userId)
        {
            DateTime serverTime = DateTime.Now;
            List<SpecialSparepartDetail> details = _specialSparepartDetailRepository.GetMany(spd => spd.SparepartId == sparepart.Id).ToList();
            foreach (var iDetails in details)
            {
                iDetails.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                iDetails.ModifyDate = serverTime;
                iDetails.ModifyUserId = userId;
                _specialSparepartDetailRepository.AttachNavigation(iDetails.CreateUser);
                _specialSparepartDetailRepository.AttachNavigation(iDetails.ModifyUser);
                _specialSparepartDetailRepository.AttachNavigation(iDetails.PurchasingDetail);
                _specialSparepartDetailRepository.AttachNavigation(iDetails.Sparepart);
                _specialSparepartDetailRepository.AttachNavigation(iDetails.SparepartManualTransaction);
                _specialSparepartDetailRepository.Update(iDetails);
            }

            sparepart.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            sparepart.ModifyDate = serverTime;
            sparepart.ModifyUserId = userId;
            Sparepart entity = _sparepartRepository.GetById(sparepart.Id);
            Map(sparepart, entity);
            _sparepartRepository.AttachNavigation(entity.CreateUser);
            _sparepartRepository.AttachNavigation(entity.ModifyUser);
            _sparepartRepository.AttachNavigation(entity.CategoryReference);
            _sparepartRepository.AttachNavigation(entity.UnitReference);
            _sparepartRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }


        public void FixSPM(int sparepartId)
        {
            DateTime serverTime = DateTime.Now;

            Sparepart sparepart = _sparepartRepository.GetById(sparepartId);

            if (sparepart != null)
            {
                // update sparepart to last stock
                SparepartStockCard lastStock = _sparepartStockCardRepository.GetMany(sc => sc.SparepartId == sparepartId).LastOrDefault();

                if (lastStock != null)
                {
                    sparepart.StockQty = lastStock.QtyLast.AsInteger();
                    _sparepartRepository.Update(sparepart);
                }

                //update spm by stockcarddetail
                List<SparepartManualTransaction> spmList = _sparepartManualTransactionRepository.GetMany(spm => spm.SparepartId == sparepartId).ToList();

                foreach (SparepartManualTransaction spm in spmList)
                {
                    SparepartStockCardDetail lastStockDetail = _sparepartStockCardDetailRepository.GetMany(scd => scd.SparepartManualTransactionId == spm.Id).LastOrDefault();

                    if (lastStockDetail != null)
                    {
                        spm.QtyRemaining = lastStockDetail.QtyLast.AsInteger();
                        _sparepartManualTransactionRepository.Update(spm);
                    }
                }

            }

            _unitOfWork.SaveChanges();
        }
    }
}
