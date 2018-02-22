using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SparepartDetailListModel : AppBaseModel
    {
        private ISparepartRepository _sparepartRepository;
        private IUnitOfWork _unitOfWork;

        public SparepartDetailListModel(ISparepartRepository sparepartRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _sparepartRepository = sparepartRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SparepartDetailViewModel> SearchSparepart(int sparepartId,
            DbConstant.SparepartDetailDataStatus status, int purchaseDetailID)
        {
            List<SparepartDetail> result = new List<SparepartDetail>();
            if (purchaseDetailID > 0)
            {
                result = _sparepartDetailRepository.GetMany(
                spd => spd.SparepartId == sparepartId && spd.Status == (int)status
                    && spd.PurchasingDetailId == purchaseDetailID).ToList();
            }
            else
            {
                result = _sparepartDetailRepository.GetMany(
                spd => spd.SparepartId == sparepartId && spd.Status == (int)status).ToList();
            }
            List<SparepartDetailViewModel> mappedResult = new List<SparepartDetailViewModel>();
            return Map(result, mappedResult);
        }
    }
}
