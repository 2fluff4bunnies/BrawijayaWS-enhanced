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
        private IInvoiceRepository _invoiceRepository;
        private IUnitOfWork _unitOfWork;

        public SPKSaleListModel(ISPKRepository spkRepository, IInvoiceRepository invoiceRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _spkRepository = spkRepository;
            _invoiceRepository = invoiceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SPKViewModel> SearchSPKSales(DateTime? dateFrom, DateTime? dateTo)
        {
            List<SPK> result = _spkRepository.GetMany(spk => spk.CategoryReference.Code == DbConstant.REF_SPK_CATEGORY_SALE).OrderBy(c => c.CreateDate).ToList();
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                result = result.Where(spk => spk.CreateDate.Date >= dateFrom && spk.CreateDate.Date <= dateTo).ToList();
            }

            List<SPKViewModel> mappedResult = new List<SPKViewModel>();
            return Map(result, mappedResult);
        }

        public InvoiceViewModel GetInvoiceBySPKId(int spkId)
        {
            Invoice result = _invoiceRepository.GetMany(i => i.SPKId == spkId).FirstOrDefault();

            InvoiceViewModel mappedResult = new InvoiceViewModel();

            return Map(result, mappedResult);
        }

        public void PrintSPK(SPKViewModel spk, int userId)
        {
            DateTime serverTime = DateTime.Now;
            SPK entity = _spkRepository.GetById(spk.Id);
            entity.StatusPrintId = (int)DbConstant.SPKPrintStatus.Printed;
            entity.ModifyDate = serverTime;
            entity.ModifyUserId = userId;

            _spkRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }
    }
}
