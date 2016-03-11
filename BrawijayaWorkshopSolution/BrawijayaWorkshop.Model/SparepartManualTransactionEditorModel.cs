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
    public class SparepartManualTransactionEditorModel : AppBaseModel
    {
        private ISparepartManualTransactionRepository _sparepartManualTransactionRepository;
        private ISparepartRepository _sparepartRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public SparepartManualTransactionEditorModel(ISparepartManualTransactionRepository sparepartManualTransactionRepository, ISparepartRepository sparepartRepository, IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _sparepartManualTransactionRepository = sparepartManualTransactionRepository;
            _sparepartRepository = sparepartRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReferenceViewModel> RetrieveTransactionType()
        {
            Reference parent = null;
            parent = _referenceRepository
               .GetMany(c => c.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE).FirstOrDefault();
            List<Reference> list = new List<Reference>();
            if (parent != null)
            {
                list = _referenceRepository.GetMany(c => c.ParentId == parent.Id).ToList();
            }
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(list, mappedResult);
        }

        public void InsertSparepartManualTransaction(SparepartManualTransactionViewModel sparepartManualTransaction)
        {
            //sparepartManualTransaction.TransactionDate = DateTime.Now;
            //Reference updateType = _referenceRepository.GetById(sparepartManualTransaction.UpdateTypeId);
            //Sparepart sparepartUpdated = _sparepartRepository.GetById(sparepartManualTransaction.SparepartId);
            //if(updateType != null && sparepartUpdated != null)
            //{
            //    if(updateType.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS)
            //    {
            //        sparepartUpdated.StockQty += sparepartManualTransaction.Qty;
            //    }
            //    else if (updateType.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_MINUS)
            //    {
            //        sparepartUpdated.StockQty -= sparepartManualTransaction.Qty;
            //    }
            //    SparepartManualTransaction entity = new SparepartManualTransaction();
            //    Map(sparepartManualTransaction, entity);
            //    _sparepartManualTransactionRepository.Add(entity);
            //    _sparepartRepository.Update(sparepartUpdated);
            //    _unitOfWork.SaveChanges();
            //}
            SparepartManualTransaction entity = new SparepartManualTransaction();
            Map(sparepartManualTransaction, entity);
            _sparepartManualTransactionRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateSparepartManualTransaction(SparepartManualTransactionViewModel sparepartManualTransaction)
        {
            Reference updateTypeNew = _referenceRepository.GetById(sparepartManualTransaction.UpdateTypeId);
            SparepartManualTransaction manualTransactionOld = _sparepartManualTransactionRepository.GetById(sparepartManualTransaction.Id);
            Sparepart sparepartUpdated = _sparepartRepository.GetById(sparepartManualTransaction.SparepartId);
            if (manualTransactionOld != null && updateTypeNew != null && sparepartUpdated != null)
            {
                Reference updateTypeOld = _referenceRepository.GetById(manualTransactionOld.UpdateTypeId);
            
                if (updateTypeOld.Code == (DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS))
                {
                    sparepartUpdated.StockQty -= manualTransactionOld.Qty;
                }
                else if (updateTypeOld.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_MINUS)
                {
                    sparepartUpdated.StockQty += manualTransactionOld.Qty;
                }

                if (updateTypeNew.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS)
                {
                    sparepartUpdated.StockQty += sparepartManualTransaction.Qty;
                }
                else if (updateTypeNew.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_MINUS)
                {
                    sparepartUpdated.StockQty -= sparepartManualTransaction.Qty;
                }
                SparepartManualTransaction entity = new SparepartManualTransaction();
                Map(sparepartManualTransaction, entity);
                _sparepartManualTransactionRepository.Update(entity);
                _sparepartRepository.Update(sparepartUpdated);
                _unitOfWork.SaveChanges();
            }
        }
    }
}
