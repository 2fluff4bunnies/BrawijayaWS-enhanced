﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SalesReturnListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IInvoiceRepository _invoiceRepository;
        private IUnitOfWork _unitOfWork;

        public SalesReturnListModel(ITransactionRepository transactionRepository,
            IInvoiceRepository invoiceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _invoiceRepository = invoiceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<InvoiceViewModel> SearchInvoiceList(DateTime? dateFrom, DateTime? dateTo)
        {
            List<Invoice> result = null;
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _invoiceRepository.GetMany(c => c.CreateDate >= dateFrom && c.CreateDate <= dateTo).OrderBy(c => c.CreateDate).ToList();
            }
            else
            {
                result = _invoiceRepository.GetAll().OrderBy(c => c.CreateDate).ToList();
            }

            List<InvoiceViewModel> mappedResult = new List<InvoiceViewModel>();
            return Map(result, mappedResult);
        }
    }
}
