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
    public class SPKSaleListModel : AppBaseModel
    {
        private ISPKRepository _spkRepository;
        private IUnitOfWork _unitOfWork;

        public SPKSaleListModel(ISPKRepository spkRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _spkRepository = spkRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SPKViewModel> SearchSPKSales(DateTime? dateFrom, DateTime? dateTo)
        {
            List<SPK> result = null;
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                result = _spkRepository.GetMany(spk => spk.CreateDate >= dateFrom 
                    && spk.CreateDate <= dateTo
                    && spk.CategoryReference.Code == DbConstant.REF_SPK_CATEGORY_SALE
                    ).OrderBy(c => c.CreateDate).ToList();
            }
            else
            {
                result = _spkRepository.GetMany(spk => spk.CategoryReference.Code == DbConstant.REF_SPK_CATEGORY_SALE).OrderBy(c => c.CreateDate).ToList();
            }

            List<SPKViewModel> mappedResult = new List<SPKViewModel>();
            return Map(result, mappedResult);
        }
    }
}
