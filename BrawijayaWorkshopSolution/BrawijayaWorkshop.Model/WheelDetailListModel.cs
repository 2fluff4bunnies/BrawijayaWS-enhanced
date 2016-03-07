﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class WheelDetailListModel : AppBaseModel
    {
        private IWheelRepository _wheelRepository;
        private IWheelDetailRepository _WheelDetailRepository;
        private IUnitOfWork _unitOfWork;

          public WheelDetailListModel(IWheelRepository WheelRepository,
            IWheelDetailRepository WheelDetailRepository, IUnitOfWork unitOfWork)
            : base()    
        {
            _wheelRepository = WheelRepository;
            _WheelDetailRepository = WheelDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<WheelDetailViewModel> SearchWheel(int WheelId,
            DbConstant.SparepartDetailDataStatus status, int purchaseDetailID)
        {
            List<WheelDetail> result = new List<WheelDetail>();
            if (purchaseDetailID > 0)
            {
                result = _WheelDetailRepository.GetMany(
                whd => whd.WheelId == WheelId && whd.SparepartDetail.Status == (int)status
                    && whd.SparepartDetail.PurchasingDetailId == purchaseDetailID).ToList();
            }
            else
            {
                result = _WheelDetailRepository.GetMany(
                spd => spd.WheelId == WheelId && spd.Status == (int)status).ToList();
            }
            List<WheelDetailViewModel> mappedResult = new List<WheelDetailViewModel>();
            return Map(result, mappedResult);
        }
    }
}
