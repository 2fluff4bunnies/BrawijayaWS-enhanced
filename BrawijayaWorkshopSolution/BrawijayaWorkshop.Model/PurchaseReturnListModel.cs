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
    public class PurchaseReturnListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IPurchasingRepository _purchasingRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private IPurchaseReturnRepository _purchaseReturnRepository;
        private IPurchaseReturnDetailRepository _purchaseReturnDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private IReferenceRepository _referenceRepository;
        private ISupplierRepository _supplierRepository;
        private ISparepartStockCardRepository _sparepartStokCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStokCardDetailRepository;
        private IUnitOfWork _unitOfWork;

        public PurchaseReturnListModel(ITransactionRepository transactionRepository,
            IPurchasingRepository purchasingRepository, IPurchasingDetailRepository purchasingDetailRepository, IPurchaseReturnRepository purchaseReturnRepository,
            IPurchaseReturnDetailRepository purchaseReturnDetailRepository,
            ISparepartRepository sparepartRepository,
            IReferenceRepository referenceRepository, 
            ISupplierRepository supplierRepository,
            ISparepartStockCardRepository sparepartStockCardRepository,
            ISparepartStockCardDetailRepository sparepartStockCardDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _purchasingRepository = purchasingRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _purchaseReturnRepository = purchaseReturnRepository;
            _purchaseReturnDetailRepository = purchaseReturnDetailRepository;
            _sparepartRepository = sparepartRepository;
            _referenceRepository = referenceRepository;
            _supplierRepository = supplierRepository;
            _sparepartStokCardRepository = sparepartStockCardRepository;
            _sparepartStokCardDetailRepository = sparepartStockCardDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<PurchaseReturnViewModel> SearchPurchaseReturnList(DateTime? dateFrom, DateTime? dateTo, int supplierID)
        {
            List<PurchaseReturn> result = null;
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _purchaseReturnRepository.GetMany(c => c.Date >= dateFrom && c.Date <= dateTo && c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.Date).ToList();
            }
            else
            {
                result = _purchaseReturnRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.Date).ToList();
            }

            if (supplierID != 0)
            {
                result = result.Where(p => p.Purchasing.SupplierId == supplierID).ToList();
            }

            List<PurchaseReturnViewModel> mappedResult = new List<PurchaseReturnViewModel>();
            Map(result, mappedResult);

            foreach (var itemMapped in mappedResult)
            {
                itemMapped.TotalPriceReturn = CalculateTotalReturn(itemMapped.Id);
            }

            return mappedResult;
        }

        public decimal CalculateTotalReturn(int purchaseReturnID)
        {
            decimal result = 0;
            List<PurchaseReturnDetail> listReturnDetail = _purchaseReturnDetailRepository.GetMany(x => x.PurchaseReturnId == purchaseReturnID).ToList();

            if(listReturnDetail != null && listReturnDetail.Count > 0)
            {
                foreach (var itemReturn in listReturnDetail)
                {
                    result += itemReturn.PurchasingDetail != null ? itemReturn.PurchasingDetail.Price : itemReturn.SparepartManualTransaction.Price;
                }
            }

            return result;
        }

        public List<SupplierViewModel> GetSupplierFilterList()
        {
            List<Supplier> result = null;
            result = _supplierRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<SupplierViewModel> mappedResult = new List<SupplierViewModel>();
            return Map(result, mappedResult);
        }

        public PurchaseReturnViewModel GetPurchaseReturn(int purchasingID)
        {
            PurchaseReturn purchaseReturn =  _purchaseReturnRepository.GetMany(x => x.PurchasingId == purchasingID && x.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
            PurchaseReturnViewModel viewModel = new PurchaseReturnViewModel();
            return Map(purchaseReturn, viewModel);
        }

        public void DeletePurchaseReturn(int purchaseReturnID, int userID)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    DateTime serverTime = DateTime.Now;

                    Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_PURCHASERETURN).FirstOrDefault();
            
                    PurchaseReturn purchaseReturn = _purchaseReturnRepository.GetById(purchaseReturnID);
                    purchaseReturn.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                    purchaseReturn.ModifyDate = serverTime;
                    purchaseReturn.ModifyUserId = userID;

                    _purchaseReturnRepository.AttachNavigation(purchaseReturn.CreateUser);
                    _purchaseReturnRepository.AttachNavigation(purchaseReturn.ModifyUser);
                    _purchaseReturnRepository.AttachNavigation(purchaseReturn.Purchasing);
                    _purchaseReturnRepository.Update(purchaseReturn);
                    _unitOfWork.SaveChanges();

                    List<PurchaseReturnDetail> listDetail = _purchaseReturnDetailRepository.GetMany(x => x.PurchaseReturnId == purchaseReturnID).ToList();
                    List<ReturnViewModel> listReturn = listDetail
                                    .GroupBy(l => l.PurchasingDetail.Sparepart)
                                    .Select(cl => new ReturnViewModel
                                    {
                                        SparepartId = cl.First().PurchasingDetail.SparepartId,
                                        ReturQty = cl.Count(),
                                        PricePerItem = cl.First().PurchasingDetail.Price
                                    }).ToList();

                    foreach (var itemDetail in listDetail)
                    {
                        itemDetail.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                        itemDetail.ModifyDate = serverTime;
                        itemDetail.ModifyUserId = userID;

                        _purchaseReturnDetailRepository.AttachNavigation(itemDetail.CreateUser);
                        _purchaseReturnRepository.AttachNavigation(itemDetail.ModifyUser);
                        _purchaseReturnRepository.AttachNavigation(itemDetail.PurchaseReturn);
                        _purchaseReturnRepository.AttachNavigation(itemDetail.PurchasingDetail);
                        _purchaseReturnDetailRepository.Update(itemDetail);

                    }

                    foreach (var itemReturn in listReturn)
                    {
                        Sparepart sparepart = _sparepartRepository.GetById(itemReturn.SparepartId);
                        sparepart.StockQty += itemReturn.ReturQty;

                        _sparepartRepository.AttachNavigation(sparepart.CreateUser);
                        _sparepartRepository.AttachNavigation(sparepart.ModifyUser);
                        _sparepartRepository.AttachNavigation(sparepart.CategoryReference);
                        _sparepartRepository.AttachNavigation(sparepart.UnitReference);
                        _sparepartRepository.Update(sparepart);

                        SparepartStockCard stockCard = new SparepartStockCard();
                        stockCard.CreateUserId = userID;
                        stockCard.PurchaseDate = serverTime;
                        stockCard.PrimaryKeyValue = purchaseReturn.Id;
                        stockCard.ReferenceTableId = transactionReferenceTable.Id;
                        stockCard.SparepartId = sparepart.Id;
                        stockCard.Description = "Pembatalan Retur Pembelian";
                        stockCard.QtyIn = itemReturn.ReturQty;
                        stockCard.QtyInPrice = Convert.ToDouble(itemReturn.ReturQty * itemReturn.PricePerItem);
                        SparepartStockCard lastStockCard = _sparepartStokCardRepository.RetrieveLastCard(sparepart.Id);
                        double lastStock = 0;
                        double lastStockPrice = 0;
                        if (lastStockCard != null)
                        {
                            lastStock = lastStockCard.QtyLast;
                            lastStockPrice = lastStockCard.QtyLastPrice;
                        }
                        stockCard.QtyFirst = lastStock;
                        stockCard.QtyFirstPrice = lastStockPrice;
                        stockCard.QtyLast = lastStock + stockCard.QtyIn;
                        stockCard.QtyLastPrice = lastStockPrice + stockCard.QtyInPrice;
                        _sparepartStokCardRepository.AttachNavigation(stockCard.CreateUser);
                        _sparepartStokCardRepository.AttachNavigation(stockCard.Sparepart);
                        _sparepartStokCardRepository.AttachNavigation(stockCard.ReferenceTable);
                        stockCard = _sparepartStokCardRepository.Add(stockCard);
                        _unitOfWork.SaveChanges();

                        SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                        stockCardDtail.ParentStockCard = stockCard;
                        stockCardDtail.PricePerItem = Convert.ToDouble(itemReturn.PricePerItem);
                        stockCardDtail.QtyIn = itemReturn.ReturQty;
                        stockCardDtail.QtyInPrice = Convert.ToDouble(itemReturn.PricePerItem * itemReturn.ReturQty);
                        SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByPurchasingId(sparepart.Id, purchaseReturn.PurchasingId);
                        double lastStockDetail = 0;
                        double lastStockDetailPrice = 0;
                        if (lastStockCardDetail != null)
                        {
                            lastStockDetail = lastStockCardDetail.QtyLast;
                            lastStockDetailPrice = lastStockCardDetail.QtyLastPrice;
                        }
                        stockCardDtail.QtyFirst = lastStockDetail;
                        stockCardDtail.QtyFirstPrice = lastStockDetailPrice;
                        stockCardDtail.QtyLast = lastStockDetail + stockCardDtail.QtyIn;
                        stockCardDtail.QtyLastPrice = lastStockDetailPrice + stockCardDtail.QtyInPrice;
                        stockCardDtail.PurchasingId = purchaseReturn.PurchasingId;

                        _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                        _sparepartStokCardDetailRepository.Add(stockCardDtail);
                        _unitOfWork.SaveChanges();
                    }        

                    _unitOfWork.SaveChanges();

                    Transaction transaction = _transactionRepository.GetMany(x => x.PrimaryKeyValue == purchaseReturnID && x.ReferenceTableId == transactionReferenceTable.Id).FirstOrDefault();
                    transaction.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                    transaction.ModifyDate = serverTime;
                    transaction.ModifyUserId = userID;

                    _transactionRepository.AttachNavigation(transaction.CreateUser);
                    _transactionRepository.AttachNavigation(transaction.ModifyUser);
                    _transactionRepository.AttachNavigation(transaction.PaymentMethod);
                    _transactionRepository.AttachNavigation(transaction.ReferenceTable);
                    _transactionRepository.Update(transaction);



                    Purchasing purchasing = _purchasingRepository.GetById(purchaseReturn.PurchasingId);
                    purchasing.Status = (int)DbConstant.PurchasingStatus.Active;
                    if (purchasing.TotalPrice != purchasing.TotalHasPaid && (purchasing.TotalPrice - purchasing.TotalHasPaid) >= (decimal)transaction.TotalTransaction)
                    {
                        purchasing.TotalHasPaid -= (decimal)transaction.TotalTransaction;
                    }

                    if (purchasing.TotalPrice == purchasing.TotalHasPaid)
                    {
                        purchasing.PaymentStatus = (int)DbConstant.PaymentStatus.Settled;
                    }
                    else
                    {
                        purchasing.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
                    }

                    _purchasingRepository.AttachNavigation(purchasing.CreateUser);
                    _purchasingRepository.AttachNavigation(purchasing.ModifyUser);
                    _purchasingRepository.AttachNavigation(purchasing.PaymentMethod);
                    _purchasingRepository.AttachNavigation(purchasing.Supplier);

                    _unitOfWork.SaveChanges();
                    trans.Commit();
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }
            }

        }

        public List<PurchaseReturnDetail> RetrievePurchaseReturnDetail(int purchaseReturnID)
        {
            List<PurchaseReturnDetail> result = _purchaseReturnDetailRepository.GetMany(x => x.PurchaseReturnId == purchaseReturnID).ToList();
            return result;
        }

        public List<ReturnViewModel> GetReturnListDetail(int purchaseReturnID, int purchasingID)
        {
            List<ReturnViewModel> result = new List<ReturnViewModel>();
            List<PurchasingDetail> listPurchasingDetail = _purchasingDetailRepository.GetMany(x => x.PurchasingId == purchasingID).ToList();

            if (purchaseReturnID > 0)
            {
                List<PurchaseReturnDetail> listDetail = this.RetrievePurchaseReturnDetail(purchaseReturnID);
                if (listDetail != null && listDetail.Count > 0)
                {
                    foreach (var itemDetail in listPurchasingDetail)
                    {
                        if (listDetail.Where(x => x.PurchasingDetail.SparepartId == itemDetail.SparepartId).Count() > 0)
                        {
                            result.Add(new ReturnViewModel
                            {
                                SparepartId = itemDetail.SparepartId,
                                SparepartName = itemDetail.Sparepart.Name,
                                ReturQty = listDetail.Where(x => x.PurchasingDetailId == itemDetail.Id).FirstOrDefault().Qty,
                                ReturQtyLimit = itemDetail.Qty,
                                PricePerItem = itemDetail.Price,
                                SparepartCode = itemDetail.Sparepart.Code,
                                UnitName = itemDetail.Sparepart.UnitReference.Name
                            });
                        }
                    }
                }
            }
            return result;
        }
    }
}
