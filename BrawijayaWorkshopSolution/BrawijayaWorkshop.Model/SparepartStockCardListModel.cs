using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SparepartStockCardListModel : AppBaseModel
    {
        private ISparepartStockCardRepository _sparepartStockCardRepository;
        private ISparepartRepository _sparepartRepository;

        public SparepartStockCardListModel(ISparepartRepository sparepartRepository,
            ISparepartStockCardRepository sparepartStockCardRepository)
        {
            _sparepartRepository = sparepartRepository;
            _sparepartStockCardRepository = sparepartStockCardRepository;
        }

        public List<SparepartViewModel> RetrieveAllSpareparts()
        {
            List<Sparepart> result = _sparepartRepository.GetAll().ToList();
            result.Insert(0, new Sparepart {
                Id = 0,
                Code = "-",
                Name = "-- Pilih Sparepart --"
            });
            List<SparepartViewModel> mappedResult = new List<SparepartViewModel>();
            return Map(result, mappedResult);
        }

        public List<SparepartStockCardViewModel> RetrieveStockCards(DateTime fromDate, DateTime toDate, int sparepartId)
        {
            List<SparepartStockCard> result = new List<SparepartStockCard>();
            DateTime lastDay = toDate.AddDays(1).AddSeconds(-1);
            if (sparepartId > 0)
            {
                result = _sparepartStockCardRepository.GetMany(stc =>
                    stc.SparepartId == sparepartId &&
                    stc.CreateDate >= fromDate && stc.CreateDate <= lastDay).ToList();
            }
            else
            {
                result = _sparepartStockCardRepository.GetMany(stc =>
                    stc.CreateDate >= fromDate && stc.CreateDate <= lastDay).ToList();
            }

            List<SparepartStockCardViewModel> mappedResult = new List<SparepartStockCardViewModel>();
            return Map(result, mappedResult);
        }
    }
}
