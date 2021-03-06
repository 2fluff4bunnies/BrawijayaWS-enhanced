﻿using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class PurchasingEditorPresenter : BasePresenter<IPurchasingEditorView, PurchasingEditorModel>
    {
        public PurchasingEditorPresenter(IPurchasingEditorView view, PurchasingEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListPurchasingDetail = new List<PurchasingDetailViewModel>();
            View.ListSupplier = Model.RetrieveSupplier();
            View.ListSparepart = Model.RetrieveSparepart();
            View.Date = DateTime.Today;
            if (View.SelectedPurchasing != null)
            {
                View.Date = View.SelectedPurchasing.Date;
                View.SupplierId = View.SelectedPurchasing.SupplierId;
                View.TotalPrice = View.SelectedPurchasing.TotalPrice;
                View.ListPurchasingDetail = Model.RetrievePurchasingDetail(View.SelectedPurchasing.Id);
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedPurchasing == null)
            {
                View.SelectedPurchasing = new PurchasingViewModel();
            }

            View.SelectedPurchasing.SupplierId = View.SupplierId;
            View.SelectedPurchasing.Date = View.Date;
            View.SelectedPurchasing.TotalPrice = View.TotalPrice;

            if (View.SelectedPurchasing.Id > 0)
            {
                Model.UpdatePurchasing(View.SelectedPurchasing, View.ListPurchasingDetail, LoginInformation.UserId);
            }
            else
            {
                Model.InsertPurchasing(View.SelectedPurchasing, View.ListPurchasingDetail, LoginInformation.UserId);
            }
        }

        public bool IsSparepartSpecial(int sparepartId)
        {
            return Model.IsSparepartWheel(sparepartId);
        }

        public bool ValidateSerialNumber(string serialNumber)
        {
            return !Model.IsSerialNumberExist(serialNumber);
        }
    }
}
