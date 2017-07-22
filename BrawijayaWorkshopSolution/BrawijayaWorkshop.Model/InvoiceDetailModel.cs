using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Model
{
    public class InvoiceDetailModel : AppBaseModel
    {
        private ISPKRepository _spkRepository;
        private ISPKScheduleRepository _spkScheduleRepository;
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private IReferenceRepository _referenceRepository;
        private ITransactionRepository _transactionRepository;
        private ITransactionDetailRepository _transactionDetailRepository;
        private IJournalMasterRepository _journalMasterRepository;
        private ISparepartRepository _sparepartRepository;
        private IUnitOfWork _unitOfWork;

        public InvoiceDetailModel(
            ISPKRepository spkRepository,
            ISPKScheduleRepository spkScheduleRepository,
            IInvoiceRepository invoiceRepository,
            IInvoiceDetailRepository invoiceDetailRepository,
            IReferenceRepository referenceRepository,
            ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IJournalMasterRepository journalMasterRepository,
            ISparepartRepository sparepartRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _spkRepository = spkRepository;
            _spkScheduleRepository = spkScheduleRepository;
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
            _journalMasterRepository = journalMasterRepository;
            _referenceRepository = referenceRepository;
            _sparepartRepository = sparepartRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReferenceViewModel> RetrievePaymentMethod()
        {
            Reference parent = _referenceRepository
                .GetMany(c => c.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD).FirstOrDefault();
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
            Map(result, mappedResult);
            foreach (var itemMappedResult in mappedResult)
            {
                if (itemMappedResult.FeePctg == null)
                {
                    itemMappedResult.FeePctg = 0;
                }
            }
            return mappedResult;
        }

        public void Print(int invoiceID)
        {
            Invoice invoice = _invoiceRepository.GetById(invoiceID);
            invoice.Status = (int)DbConstant.InvoiceStatus.Printed;
            _invoiceRepository.Update(invoice);
            _unitOfWork.SaveChanges();
        }

        public List<InvoiceSparepartViewModel> GetInvoiceSparepartList(int invoiceID)
        {
            List<InvoiceSparepartViewModel> result = new List<InvoiceSparepartViewModel>();
            List<InvoiceDetail> listInvoiceDetail = _invoiceDetailRepository.GetMany(x => x.InvoiceId == invoiceID).ToList();

            int[] sparepartIDs = listInvoiceDetail.Select(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId).Distinct().ToArray();
            foreach (var sparepartID in sparepartIDs)
            {
                result.Add(new InvoiceSparepartViewModel
                {
                    SparepartName = _sparepartRepository.GetById(sparepartID).Name,
                    Qty = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId == sparepartID).Count(),
                    SubTotalPrice = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId == sparepartID).Sum(x=>x.SubTotalPrice),
                    SparepartCode = _sparepartRepository.GetById(sparepartID).Code,
                    UnitCategoryName = _sparepartRepository.GetById(sparepartID).UnitReference.Name,
                });
            }

            Invoice invoice = _invoiceRepository.GetById(invoiceID);
            if (invoice.SPK.isContractWork)
            {
                result.Add(new InvoiceSparepartViewModel
                {
                    SparepartName = "Borongan",
                    Qty = 1,
                    SubTotalPrice = (invoice.SPK.ContractWorkFee * (0.2).AsDecimal()).AsDouble(),
                    SparepartCode = "Biaya Tukang",
                    UnitCategoryName = "",
                });
            }
            else
            {
                decimal ServiceFee = 0;

                TimeSpan SPKTimeSpan = invoice.CreateDate - invoice.SPK.CreateDate;
                int SPKWorkingDays = Math.Ceiling(SPKTimeSpan.TotalDays).AsInteger();

                for (int i = 0; i < SPKWorkingDays; i++)
                {
                    List<Mechanic> involvedMechanic = (from sched in _spkScheduleRepository.GetMany(sc => sc.CreateDate.Day == invoice.SPK.CreateDate.Day + i && sc.SPKId == invoice.SPK.Id).ToList()
                                                       select sched.Mechanic).ToList();

                    foreach (Mechanic mechanic in involvedMechanic)
                    {
                        int mechanicJobForToday = _spkScheduleRepository.GetMany(sc => sc.CreateDate.Day == invoice.SPK.CreateDate.Day + i && sc.MechanicId == mechanic.Id).Count();

                        decimal mechanicFeeForToday = mechanic.BaseFee / mechanicJobForToday;

                        result.Add(new InvoiceSparepartViewModel
                        {
                            SparepartName = mechanic.Name,
                            Qty = 1,
                            SubTotalPrice = mechanicFeeForToday.AsDouble(),
                            SparepartCode = "Biaya Tukang",
                            UnitCategoryName = "",
                        });
                    }
                }
            }
            return result;
        }
    }
}
