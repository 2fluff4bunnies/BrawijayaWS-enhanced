using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class FIFOSparepartStockCardListModel : AppBaseModel
    {
        private ISparepartStockCardRepository _sparepartStockCardRepository;
        private ISparepartRepository _sparepartRepository;

        public FIFOSparepartStockCardListModel(ISparepartRepository sparepartRepository,
            ISparepartStockCardRepository sparepartStockCardRepository)
        {
            _sparepartRepository = sparepartRepository;
            _sparepartStockCardRepository = sparepartStockCardRepository;
        }

        public List<GroupSparepartStockCardViewModel> RetrieveStockCards(DateTime fromDate, DateTime toDate, int sparepartId)
        {
            List<GroupSparepartStockCard> result = new List<GroupSparepartStockCard>();
            DateTime lastDay = toDate.AddDays(1).AddSeconds(-1);
            result = _sparepartStockCardRepository.RetrieveFIFOCurrentSparepart(fromDate, toDate, sparepartId);

            List<GroupSparepartStockCardViewModel> mappedResult = new List<GroupSparepartStockCardViewModel>();
            return Map(result, mappedResult);
        }
    }
}
