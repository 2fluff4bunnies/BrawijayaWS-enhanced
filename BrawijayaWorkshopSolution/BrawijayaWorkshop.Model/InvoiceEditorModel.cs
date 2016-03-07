using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class InvoiceEditorModel : AppBaseModel
    {
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private IReferenceRepository _referenceRepository;
        private ITransactionRepository _transactionRepository;
        private IUnitOfWork _unitOfWork;

        public InvoiceEditorModel(IInvoiceRepository invoiceRepository,
            IInvoiceDetailRepository invoiceDetailRepository,
            IReferenceRepository referenceRepository,
            ITransactionRepository transactionRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _transactionRepository = transactionRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReferenceViewModel> RetrievePaymentMethod()
        {
            Reference parent = _referenceRepository
                .GetMany(c => c.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD).FirstOrDefault();
            List<Reference> list = new List<Reference>();
            if (parent != null)
            {
                list = _referenceRepository.GetMany(c => c.ParentId == parent.Id).ToList();
            }
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(list, mappedResult);
        }

        public List<InvoiceDetailViewModel> RetrieveInvoiceDetail(int invoiceID)
        {
            List<InvoiceDetail> result = _invoiceDetailRepository.GetMany(x => x.InvoiceId == invoiceID).ToList();
            List<InvoiceDetailViewModel> mappedResult = new List<InvoiceDetailViewModel>();
            return Map(result, mappedResult);
        }

        public TransactionViewModel RetrieveTransaction(int invoiceID)
        {
            Transaction result = _transactionRepository.GetMany(x => x.PrimaryKeyValue == invoiceID).FirstOrDefault();
            TransactionViewModel mappedResult = new TransactionViewModel();
            return Map(result, mappedResult);
        }

        public void UpdateInvoice(InvoiceViewModel invoice, List<InvoiceDetailViewModel> invoiceDetails, TransactionViewModel transaction)
        {
            Invoice entity = _invoiceRepository.GetById<int>(invoice.Id);
            Map(invoice, entity);
            _invoiceRepository.Update(entity);
            foreach (var invoiceDetail in invoiceDetails)
            {
                InvoiceDetail entityDetail = _invoiceDetailRepository.GetById<int>(invoiceDetail.Id);
                Map(invoiceDetail, entityDetail);
                _invoiceDetailRepository.Update(entityDetail);
            }
            if (transaction != null)
            {
                Transaction entityTransaction = _transactionRepository.GetMany(x => x.PrimaryKeyValue == invoice.Id).FirstOrDefault();
                Map(transaction, entityTransaction);
                _transactionRepository.Update(entityTransaction);
            }
            else
            {
                Transaction entityTransaction = new Transaction();
                Map(transaction, entityTransaction);
                _transactionRepository.Add(entityTransaction);
            }

            _unitOfWork.SaveChanges();
        }
    }
}
