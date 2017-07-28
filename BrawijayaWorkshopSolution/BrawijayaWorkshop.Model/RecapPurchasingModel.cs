using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class RecapPurchasingModel : AppBaseModel
    {
        private IPurchasingRepository _purchasingRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISupplierRepository _supplierRepository;
        private IReferenceRepository _referenceRepository;
        private ISparepartRepository _sparepartRepository;
        private IPurchaseReturnRepository _purchaseReturnRepository;
        private IPurchaseReturnDetailRepository _purchaseReturnDetailRepository;

        public RecapPurchasingModel(IPurchasingRepository purchasingRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISupplierRepository supplierRepository,
            IReferenceRepository referenceRepository,
            ISparepartRepository sparepartRepository,
            IPurchaseReturnRepository purchaseReturnRepository,
            IPurchaseReturnDetailRepository purchaseReturnDetailRepository)
            : base()
        {
            _purchasingRepository = purchasingRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _supplierRepository = supplierRepository;
            _referenceRepository = referenceRepository;
            _sparepartRepository = sparepartRepository;
            _purchaseReturnRepository = purchaseReturnRepository;
            _purchaseReturnDetailRepository = purchaseReturnDetailRepository;
        }

        public List<SupplierViewModel> RetrieveSuppliers()
        {
            List<Supplier> result = _supplierRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<SupplierViewModel> mappedResult = new List<SupplierViewModel>();
            return Map(result, mappedResult);
        }

        public List<RecapPurchasingItemViewModel> RetrieveRecap(DateTime dateFrom, DateTime dateTo,
            int supplierId)
        {
            List<Purchasing> purchaseResult = _purchasingRepository.GetMany(i =>
                DbFunctions.TruncateTime(i.CreateDate) >= DbFunctions.TruncateTime(dateFrom) &&
                DbFunctions.TruncateTime(i.CreateDate) <= DbFunctions.TruncateTime(dateTo) &&
                i.Status != (int)DbConstant.DefaultDataStatus.Deleted &&
                i.PaymentStatus != (int)DbConstant.PaymentStatus.Settled &&
                i.SupplierId == supplierId).ToList();

            purchaseResult = purchaseResult.OrderBy(i => i.CreateDate).ToList();
            List<PurchasingViewModel> mappedPurchaseResult = new List<PurchasingViewModel>();
            Map(purchaseResult, mappedPurchaseResult);

            List<PurchaseReturn> purchaseReturnResult = _purchaseReturnRepository.GetMany(i =>
                DbFunctions.TruncateTime(i.CreateDate) >= DbFunctions.TruncateTime(dateFrom) &&
                DbFunctions.TruncateTime(i.CreateDate) <= DbFunctions.TruncateTime(dateTo) &&
                i.Status != (int)DbConstant.DefaultDataStatus.Deleted &&
                i.Purchasing.PaymentStatus != (int)DbConstant.PaymentStatus.Settled &&
                i.Purchasing.SupplierId == supplierId).ToList();

            purchaseReturnResult = purchaseReturnResult.OrderBy(i => i.CreateDate).ToList();
            List<PurchaseReturnViewModel> mappedPurchaseReturnResult = new List<PurchaseReturnViewModel>();
            Map(purchaseReturnResult, mappedPurchaseReturnResult);

            List<RecapPurchasingItemViewModel> mappedResult = new List<RecapPurchasingItemViewModel>();

            foreach (var itemPurchase in mappedPurchaseResult)
            {
                mappedResult.Add(new RecapPurchasingItemViewModel
                    {
                        Code = itemPurchase.Code,
                        Date = itemPurchase.Date,
                        IsReturn = false,
                        Supplier = itemPurchase.Supplier,
                        TotalPrice = itemPurchase.TotalPrice
                    });
            }

            foreach (var itemPurchaseReturn in mappedPurchaseReturnResult)
            {
                mappedResult.Add(new RecapPurchasingItemViewModel
                {
                    Code = itemPurchaseReturn.Code,
                    Date = itemPurchaseReturn.Date,
                    IsReturn = true,
                    Supplier = itemPurchaseReturn.Purchasing.Supplier,
                    TotalPrice = -1 * itemPurchaseReturn.TotalPriceReturn
                });
            }
            return mappedResult;
        }
    }
}
