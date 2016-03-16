using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SpecialSparepartDetailListModel : AppBaseModel
    {
        private ISpecialSparepartRepository _specialSparepartRepository;
        private ISpecialSparepartDetailRepository _WheelDetailRepository;
        private IUnitOfWork _unitOfWork;

          public SpecialSparepartDetailListModel(ISpecialSparepartRepository WheelRepository,
            ISpecialSparepartDetailRepository WheelDetailRepository, IUnitOfWork unitOfWork)
            : base()    
        {
            _specialSparepartRepository = WheelRepository;
            _WheelDetailRepository = WheelDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SpecialSparepartDetailViewModel> SearchWheel(int WheelId,
            DbConstant.SparepartDetailDataStatus status, int purchaseDetailID)
        {
            List<SpecialSparepartDetail> result = new List<SpecialSparepartDetail>();
            if (purchaseDetailID > 0)
            {
                result = _WheelDetailRepository.GetMany(
                whd => whd.SpecialSparepartId == WheelId && whd.SparepartDetail.Status == (int)status
                    && whd.SparepartDetail.PurchasingDetailId == purchaseDetailID).ToList();
            }
            else
            {
                result = _WheelDetailRepository.GetMany(
                spd => spd.SpecialSparepartId == WheelId && spd.Status == (int)status).ToList();
            }
            List<SpecialSparepartDetailViewModel> mappedResult = new List<SpecialSparepartDetailViewModel>();
            return Map(result, mappedResult);
        }
    }
}
