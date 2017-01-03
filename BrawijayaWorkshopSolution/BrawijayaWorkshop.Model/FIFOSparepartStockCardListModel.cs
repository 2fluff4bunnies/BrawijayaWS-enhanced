using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Model
{
    public class FIFOSparepartStockCardListModel : AppBaseModel
    {
        private ISparepartStockCardDetailRepository _sparepartStockCardDetailRepository;

        public FIFOSparepartStockCardListModel(ISparepartStockCardDetailRepository sparepartStockCardDetailRepository)
        {
            _sparepartStockCardDetailRepository = sparepartStockCardDetailRepository;
        }

        public List<GroupSparepartStockCardViewModel> RetrieveStockCards(DateTime fromDate, DateTime toDate, int sparepartId)
        {
            List<GroupSparepartStockCard> result = new List<GroupSparepartStockCard>();
            DateTime lastDay = toDate.AddDays(1).AddSeconds(-1);
            result = _sparepartStockCardDetailRepository.RetrieveFIFOCurrentSparepart(fromDate, toDate, sparepartId);

            List<GroupSparepartStockCardViewModel> mappedResult = new List<GroupSparepartStockCardViewModel>();
            return Map(result, mappedResult);
        }
    }
}
