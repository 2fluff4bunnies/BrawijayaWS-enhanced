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
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private IUnitOfWork _unitOfWork;

        public SpecialSparepartDetailListModel(ISpecialSparepartRepository WheelRepository,
          ISpecialSparepartDetailRepository WheelDetailRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _specialSparepartRepository = WheelRepository;
            _specialSparepartDetailRepository = WheelDetailRepository;
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
    }
}
