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
        private ISparepartDetailRepository _sparepartDetailRepository;
        private ISpecialSparepartRepository _specialSparepartRepository;
        private ISpecialSparepartDetailRepository _wheelDetailRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public SparepartManualTransactionEditorModel(ISparepartManualTransactionRepository sparepartManualTransactionRepository, 
            ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            ISpecialSparepartRepository wheelRepository,
            ISpecialSparepartDetailRepository wheelDetailRepository,
            IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _sparepartManualTransactionRepository = sparepartManualTransactionRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _specialSparepartRepository = wheelRepository;
            _wheelDetailRepository = wheelDetailRepository;
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

        public void InsertSparepartManualTransaction(SparepartManualTransactionViewModel sparepartManualTransaction, int userId)
        {
            DateTime serverTime = DateTime.Now;
            sparepartManualTransaction.CreateDate = serverTime;
            sparepartManualTransaction.CreateUserId = userId;
            sparepartManualTransaction.ModifyDate = serverTime;
            sparepartManualTransaction.ModifyUserId = userId;
            sparepartManualTransaction.TransactionDate = serverTime;
            Reference updateType = _referenceRepository.GetById(sparepartManualTransaction.UpdateTypeId);
            Sparepart sparepartUpdated = _sparepartRepository.GetById(sparepartManualTransaction.SparepartId);
            if (updateType != null && sparepartUpdated != null)
            {
                SparepartManualTransaction entity = new SparepartManualTransaction();
                Map(sparepartManualTransaction, entity);
                SparepartManualTransaction manualTransaction = _sparepartManualTransactionRepository.Add(entity);
                
                if (updateType.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS)
                {
                    sparepartUpdated.StockQty += sparepartManualTransaction.Qty;

                    SparepartDetail lastSPDetail = _sparepartDetailRepository.
                    GetMany(c => c.SparepartId == sparepartManualTransaction.SparepartId).OrderByDescending(c => c.Id)
                    .FirstOrDefault();
                    string lastSPID = string.Empty;
                    if (lastSPDetail != null) lastSPID = lastSPDetail.Code;
                    for (int i = 1; i <= sparepartManualTransaction.Qty; i++)
                    {
                        SparepartDetail spDetail = new SparepartDetail();
                        if (string.IsNullOrEmpty(lastSPID))
                        {
                            lastSPID = sparepartUpdated.Code + "0000000001";
                        }
                        else
                        {
                            lastSPID = sparepartUpdated.Code + (Convert.ToInt32(lastSPID.Substring(lastSPID.Length - 10)) + 1)
                                .ToString("D10");
                        }
                        spDetail.SparepartManualTransaction = manualTransaction;
                        spDetail.SparepartId = sparepartUpdated.Id;
                        spDetail.Code = lastSPID;
                        spDetail.CreateDate = serverTime;
                        spDetail.CreateUserId = userId;
                        spDetail.ModifyUserId = userId;
                        spDetail.ModifyDate = serverTime;
                        spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Active;
                        SparepartDetail insertedSpDetail = _sparepartDetailRepository.Add(spDetail);

                        if (!string.IsNullOrEmpty(sparepartManualTransaction.SerialNumber))
                        { 
                            SpecialSparepart specialSparepart = _specialSparepartRepository.GetMany(w=> w.SparepartId == sparepartUpdated.Id).FirstOrDefault();

                            if (specialSparepart != null)
                            {
                                SpecialSparepartDetail wDetail = new SpecialSparepartDetail();
                                wDetail.SparepartDetail = insertedSpDetail;
                                wDetail.SpecialSparepartId = specialSparepart.Id;
                                wDetail.SerialNumber = sparepartManualTransaction.SerialNumber;
                                wDetail.CreateDate = serverTime;
                                wDetail.CreateUserId = userId;
                                wDetail.ModifyUserId = userId;
                                wDetail.ModifyDate = serverTime;
                                wDetail.Status = (int)DbConstant.WheelDetailStatus.Ready;

                                _wheelDetailRepository.Add(wDetail);
                            }
                        }

                    }
                }
                else if (updateType.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_MINUS)
                {
                    sparepartUpdated.StockQty -= sparepartManualTransaction.Qty;

                    List<SparepartDetail> spDetails = _sparepartDetailRepository.
                    GetMany(c => c.SparepartId == sparepartManualTransaction.SparepartId).OrderByDescending(c => c.Id)
                    .Take(sparepartManualTransaction.Qty).ToList();
                    foreach (var spDetail in spDetails)
                    {
                        _sparepartDetailRepository.Delete(spDetail);
                    }
                }
                _sparepartRepository.Update(sparepartUpdated);
                _unitOfWork.SaveChanges();
            }
        }

        public void UpdateSparepartManualTransaction(SparepartManualTransactionViewModel sparepartManualTransaction, int userId)
        {
            DateTime serverTime = DateTime.Now;
            sparepartManualTransaction.ModifyDate = serverTime;
            sparepartManualTransaction.ModifyUserId = userId; 
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

        public bool IsThisWheel(int sparepartId)
        {
            SpecialSparepart specialSparepart = _specialSparepartRepository.GetMany(w => w.SparepartId == sparepartId && w.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();

            return specialSparepart != null;
        }
    }
}
