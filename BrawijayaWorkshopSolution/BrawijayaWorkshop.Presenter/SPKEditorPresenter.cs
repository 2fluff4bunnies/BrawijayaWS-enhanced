﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKEditorPresenter : BasePresenter<ISPKEditorView, SPKEditorModel>
    {
        public SPKEditorPresenter(ISPKEditorView view, SPKEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.FingerprintIP = Model.GetFingerprintIpAddress();
            View.FingerpringPort = Model.GetFingerprintPort();
            View.CategoryDropdownList = Model.GetSPKCategoryList();
            View.VehicleDropdownList = Model.GetSPKVehicleList();
            View.SparepartLookupList = Model.LoadSparepart();
            View.SparepartWheelLookupList = Model.LoadSparepartWheel();
            View.RepairThreshold = Model.GetRepairThreshold().AsDecimal();
            View.ServiceThreshold = Model.GetServiceThreshold().AsDecimal();
            View.ContractThreshold = Model.GetContractThreshold().AsDecimal();
            View.AssignedSchedule = new List<SPKScheduleViewModel>();

            if (View.ParentSPK != null)
            {
                View.SelectedSPK = new SPKViewModel
                {
                    Vehicle = View.ParentSPK.Vehicle,
                    CategoryReference = View.ParentSPK.CategoryReference,
                    CategoryReferenceId = View.ParentSPK.CategoryReferenceId,
                    DueDate = View.ParentSPK.DueDate,
                    SPKParent = View.ParentSPK,
                    TotalSparepartPrice = View.ParentSPK.TotalSparepartPrice,
                    Description = View.Description,
                    isContractWork = View.ParentSPK.isContractWork,
                    ContractWorkFee = View.ParentSPK.ContractWorkFee,
                    Contractor = View.ParentSPK.Contractor,
                    Kilometers = View.ParentSPK.Kilometers,
                    CostEstimation = View.ParentSPK.CostEstimation
                };

                View.CategoryId = View.SelectedSPK.CategoryReference.Id;
                View.VehicleId = View.SelectedSPK.Vehicle.Id;
                View.DueDate = View.SelectedSPK.DueDate;
                View.TotalSparepartPrice = View.SelectedSPK.TotalSparepartPrice;
                View.Description = View.SelectedSPK.Description;
                View.isContractWork = View.SelectedSPK.isContractWork;
                View.ContractWorkFee = View.SelectedSPK.ContractWorkFee;
                View.Contractor = View.SelectedSPK.Contractor;
                View.Kilometers = View.SelectedSPK.Kilometers;
                View.CostEstimation = View.SelectedSPK.CostEstimation;
                View.AssignedSchedule = new List<SPKScheduleViewModel>();

                View.SPKSparepartList = Model.GetEndorsedSPKSparepartList(View.ParentSPK.Id);
                View.SPKSparepartDetailList = Model.GetEndorsedSPKSparepartDetailList(View.ParentSPK.Id);

                LoadVehicleWheel();
            }
        }

        public void SaveChanges()
        {
            View.SelectedSPK = new SPKViewModel();
            View.SelectedSPK.CategoryReferenceId = View.CategoryId;
            View.SelectedSPK.VehicleId = View.VehicleId;
            View.SelectedSPK.DueDate = View.DueDate;
            View.SelectedSPK.TotalSparepartPrice = View.TotalSparepartPrice;
            View.SelectedSPK.Description = View.Description;
            View.SelectedSPK.Kilometers = View.Kilometers;
            View.SelectedSPK.VehicleGroupId = View.SelectedVehicle.VehicleGroupId;
            View.SelectedSPK.CostEstimation = View.CostEstimation;
            View.SelectedSPK.Vehicle = View.SelectedVehicle;
            View.SelectedSPK.CreateDate = View.Date;

            if (View.isContractWork)
            {
                View.SelectedSPK.isContractWork = View.isContractWork;
                View.SelectedSPK.ContractWorkFee = View.ContractWorkFee;
                View.SelectedSPK.Contractor = View.Contractor;
            }

            View.SelectedSPK = Model.InsertSPK(View.SelectedSPK, View.SPKSparepartList, View.SPKSparepartDetailList,
                View.VehicleWheelList, View.AssignedSchedule, LoginInformation.UserId, View.IsNeedApproval);
            if (View.ParentSPK != null)
            {
                Model.AbortParentSPK(View.ParentSPK, LoginInformation.UserId);
            }
        }
        public void PopulateSparepartDetail()
        {
            View.SPKSparepartDetailList.AddRange(Model.GetRandomDetails(View.SparepartToInsert.Id, View.SparepartQty, View.SSDetailId));
        }

        public void RestoreSparepartDetail(List<SPKDetailSparepartDetailViewModel> details)
        {
            Model.RestoreRandomDetails(details);
        }

        public void SetSelectedWheelDetailToChange(int wheelDetailId)
        {
            View.SelectedWheelDetailToChange = Model.GetWheelDetailById(wheelDetailId);
        }

        public void SendApproval()
        {
            try
            {
                SimpleEmailSenderUtils.SendEmail(RuntimeConstant.EMAIL_SUBJECT_REQUESTAPPROVALSPK,
                    View.ApprovalEmailBody.Replace(RuntimeConstant.EMAIL_APPROVALSPK_BODY, View.SelectedSPK.Code),
                    View.ApprovalEmailTo, View.ApprovalEmailFrom, string.Empty, string.Empty, string.Empty);
            }
            catch (System.Exception)
            {
            }
        }

        public int getPendingSparpartQty()
        {
            return Model.getPendingSparpartQty(View.SparepartId);
        }

        public void Print()
        {
            Model.PrintSPK(View.SelectedSPK, LoginInformation.UserId);
        }

        public SparepartViewModel GetSpecialSparepart()
        {
            return Model.GetSparepartSpecial(View.SparepartId);
        }

        public SpecialSparepartDetailViewModel GetSpecialSparepartDetail(int id)
        {
            return Model.GetSpecialSparepartDetail(id);
        }

        public bool IsUsedSparepartRequired()
        {
            return Model.IsUsedSparepartRequired(View.SparepartId);
        }

        public void GetLastUsageRecord()
        {
            View.LastUsageRecord = Model.GetSparepartLastUsageRecord(View.VehicleId, View.SparepartId);
        }

        public void LoadSSDetails(int specialSparepartId)
        {
            View.SSDetailList = Model.loadSSDetail(specialSparepartId);
        }

        public void LoadVehicleWheel()
        {
            if (View.ParentSPK != null)
            {
                View.VehicleWheelList = Model.getCurrentVehicleWheel(View.VehicleId, View.ParentSPK.Id);
            }
            else
            {
                View.VehicleWheelList = Model.getCurrentVehicleWheel(View.VehicleId, 0);
            }
        }

        public void LoadWheelDetail(int sparepartId)
        {
            View.WheelDetailList = Model.RetrieveReadyWheelDetails(sparepartId);
        }

        public VehicleWheelViewModel ResetSelectedWheel(int VehicleWheelId)
        {
            return Model.GetVehicleWHeelById(VehicleWheelId);
        }

        public int SPKSalesCategoryReferenceId()
        {
            return Model.SPKSalesCategoryReferenceId();
        }

        public decimal GetAllPurchaseByVehicleToday()
        {
            if (View.ParentSPK != null)
            {
                return Model.AllPurchaseByVehicle(View.VehicleId, View.ParentSPK.Id);
            }
            else
            {
                return Model.AllPurchaseByVehicle(View.VehicleId, 0);
            }
        }
    }
}
