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
    public class UsedGoodTransactionEditorModel : AppBaseModel
    {
        private IUsedGoodTransactionRepository _usedGoodTransactionRepository;
        private IUsedGoodRepository _usedGoodRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public UsedGoodTransactionEditorModel(IUsedGoodTransactionRepository usedGoodTransactionRepository, IUsedGoodRepository usedGoodRepository, IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _usedGoodTransactionRepository = usedGoodTransactionRepository;
            _usedGoodRepository = usedGoodRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReferenceViewModel> RetrieveTransactionType(bool isManual)
        {
            Reference parent = null;
            if (isManual)
            {
                parent = _referenceRepository
               .GetMany(c => c.Code == DbConstant.REF_USEDGOOD_TRANSACTION_MANUAL_TYPE).FirstOrDefault();
            }
            else
            {
                parent = _referenceRepository
               .GetMany(c => c.Code == DbConstant.REF_USEDGOOD_TRANSACTION_TYPE).FirstOrDefault();
            }
            List<Reference> list = new List<Reference>();
            if (parent != null)
            {
                list = _referenceRepository.GetMany(c => c.ParentId == parent.Id).ToList();
            }
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(list, mappedResult);
        }

        public List<UsedGoodViewModel> RetrieveUsedGoodList()
        {
            List<UsedGood> usedGoods = null;

            usedGoods = _usedGoodRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<UsedGoodViewModel> mappedResult = new List<UsedGoodViewModel>();
            return Map(usedGoods, mappedResult);
        }

        public void InsertUsedGoodTransaction(UsedGoodTransactionViewModel usedGoodTransaction, int userID)
        {
            DateTime serverTime = DateTime.Now;

            usedGoodTransaction.CreateDate = serverTime;
            usedGoodTransaction.CreateUserId = userID;
            usedGoodTransaction.ModifyDate = serverTime;
            usedGoodTransaction.ModifyUserId = userID;
            usedGoodTransaction.TransactionDate = serverTime;
            usedGoodTransaction.TotalPrice = usedGoodTransaction.Qty * usedGoodTransaction.ItemPrice;
            UsedGoodTransaction entity = new UsedGoodTransaction();
            Map(usedGoodTransaction, entity);
            _usedGoodTransactionRepository.Add(entity);
            Reference updateType = _referenceRepository.GetById(usedGoodTransaction.TypeReferenceId);
            UsedGood usedGoodUpdated = _usedGoodRepository.GetById(usedGoodTransaction.UsedGoodId);
            if (updateType != null && usedGoodUpdated != null)
            {
                if (updateType.Code == DbConstant.REF_USEDGOOD_TRANSACTION_MANUAL_TYPE_PLUS)
                {
                    usedGoodUpdated.Stock += usedGoodTransaction.Qty;
                }
                else if (updateType.Code == DbConstant.REF_USEDGOOD_TRANSACTION_MANUAL_TYPE_MINUS)
                {
                    usedGoodUpdated.Stock -= usedGoodTransaction.Qty;
                }
                else if (updateType.Code == DbConstant.REF_USEDGOOD_TRANSACTION_TYPE_RECYCLE)
                {
                    usedGoodUpdated.Stock -= usedGoodTransaction.Qty;
                }
                else if (updateType.Code == DbConstant.REF_USEDGOOD_TRANSACTION_TYPE_SOLD)
                {
                    usedGoodUpdated.Stock -= usedGoodTransaction.Qty;
                }
            }
            _usedGoodRepository.Update(usedGoodUpdated);
            _unitOfWork.SaveChanges();
        }

        public void UpdateUsedGoodTransaction(UsedGoodTransactionViewModel usedGoodTransaction, int userID)
        {
            DateTime serverTime = DateTime.Now;
            Reference updateTypeNew = _referenceRepository.GetById(usedGoodTransaction.TypeReferenceId);
            UsedGoodTransaction manualTransactionOld = _usedGoodTransactionRepository.GetById(usedGoodTransaction.Id);
            UsedGood usedGoodUpdated = _usedGoodRepository.GetById(usedGoodTransaction.UsedGoodId);
            if (manualTransactionOld != null && updateTypeNew != null && usedGoodUpdated != null)
            {
                Reference updateTypeOld = _referenceRepository.GetById(manualTransactionOld.TypeReferenceId);

                if (updateTypeOld.Code == (DbConstant.REF_USEDGOOD_TRANSACTION_MANUAL_TYPE_PLUS))
                {
                    usedGoodUpdated.Stock -= manualTransactionOld.Qty;
                }
                else if (updateTypeOld.Code == DbConstant.REF_USEDGOOD_TRANSACTION_MANUAL_TYPE_MINUS)
                {
                    usedGoodUpdated.Stock += manualTransactionOld.Qty;
                }
                else if (updateTypeOld.Code == DbConstant.REF_USEDGOOD_TRANSACTION_TYPE_RECYCLE)
                {
                    usedGoodUpdated.Stock += manualTransactionOld.Qty;
                }
                else if (updateTypeOld.Code == DbConstant.REF_USEDGOOD_TRANSACTION_TYPE_SOLD)
                {
                    usedGoodUpdated.Stock += manualTransactionOld.Qty;
                }


                if (updateTypeNew.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS)
                {
                    usedGoodUpdated.Stock += usedGoodTransaction.Qty;
                }
                else if (updateTypeNew.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_MINUS)
                {
                    usedGoodUpdated.Stock -= usedGoodTransaction.Qty;
                }
                else if (updateTypeNew.Code == DbConstant.REF_USEDGOOD_TRANSACTION_TYPE_RECYCLE)
                {
                    usedGoodUpdated.Stock -= usedGoodTransaction.Qty;
                }
                else if (updateTypeNew.Code == DbConstant.REF_USEDGOOD_TRANSACTION_TYPE_SOLD)
                {
                    usedGoodUpdated.Stock -= usedGoodTransaction.Qty;
                }

                manualTransactionOld.TypeReferenceId = usedGoodTransaction.TypeReferenceId;
                manualTransactionOld.UsedGoodId = usedGoodTransaction.UsedGoodId;
                manualTransactionOld.Qty = usedGoodTransaction.Qty;
                manualTransactionOld.ItemPrice = usedGoodTransaction.ItemPrice;
                manualTransactionOld.TotalPrice = manualTransactionOld.Qty * manualTransactionOld.ItemPrice;
                manualTransactionOld.ModifyDate = serverTime;
                manualTransactionOld.ModifyUserId = userID;

                _usedGoodTransactionRepository.Update(manualTransactionOld);
                _usedGoodRepository.Update(usedGoodUpdated);
                _unitOfWork.SaveChanges();
            }
        }
    }
}
