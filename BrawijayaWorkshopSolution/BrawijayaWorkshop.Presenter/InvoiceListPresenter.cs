﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using LINQtoCSV;

namespace BrawijayaWorkshop.Presenter
{
    public class InvoiceListPresenter : BasePresenter<IInvoiceListView, InvoiceListModel>
    {
        public InvoiceListPresenter(IInvoiceListView view, InvoiceListModel model)
            : base(view, model) { }

        public void InitData()
        {
            View.InvoiceStatusList = GetInvoiceStatusDropdownList();
            View.DateFromFilter = DateTime.Now;
            View.DateToFilter = DateTime.Now;
            View.InvoiceStatusFilter = 9;
            List<CustomerViewModel> listCustomer = Model.GetAllCustomer();
            listCustomer.Insert(0, new CustomerViewModel
            {
                Id = 0,
                CompanyName = "Semua",
                Address = "Semua"
            });
            View.CustomerListOption = listCustomer;
        }

        public void LoadInvoiceList()
        {
            int paymentStatus = -1;
            if(string.Compare(View.InvoiceStatusPayment, "Belum Lunas", true) == 0)
            {
                paymentStatus = 0;
            }
            if (string.Compare(View.InvoiceStatusPayment, "Lunas", true) == 0)
            {
                paymentStatus = 1;
            }

            View.InvoiceListData = Model.SearchInvoice(View.DateFromFilter, View.DateToFilter, (DbConstant.InvoiceStatus)View.InvoiceStatusFilter, View.SelectedCustomerId, paymentStatus);
        }

        public void ExportToCSV()
        {
            CsvContext cc = new CsvContext();
            CsvFileDescription outputFileDescription = new CsvFileDescription
            {
                QuoteAllFields = true,
                SeparatorChar = ';', // tab delimited
                FirstLineHasColumnNames = true,
                FileCultureName = "en-US"
            };

            // prepare invoices
            List<InvoiceDetailViewModel> listDetails = new List<InvoiceDetailViewModel>();
            foreach (var item in View.InvoiceListData)
            {
                listDetails.AddRange(Model.GetInvoiceDetailsByParentId(item.Id));
            }

            var exportInvoices =
                from inv in listDetails
                group inv by
                new { InvoiceCode = inv.Invoice.Code, inv.Invoice.CreateDate, 
                    inv.Invoice.SPK.Vehicle.Customer.CompanyName,
                    VehicleCode = inv.Invoice.SPK.Vehicle.Code,
                    inv.Invoice.SPK.Vehicle.ActiveLicenseNumber,
                    inv.Invoice.TotalPrice
                } into g
                select new
                {
                    g.Key.InvoiceCode,
                    g.Key.CreateDate,
                    g.Key.VehicleCode,
                    VehicleLicenseNumber = g.Key.ActiveLicenseNumber,
                    GrandTotalInvoice = g.Key.TotalPrice,
                    Sparepart = g.First().SPKDetailSparepartDetail.SPKDetailSparepart.Sparepart.Name,
                    Quantity = g.Count(),
                    SubTotal = g.Sum(inv => inv.SubTotalPrice)
                };

            cc.Write(exportInvoices, View.ExportFileName, outputFileDescription);
        }

        public void PrintAll()
        {
            Model.Print(View.InvoiceListData.Where(i => i.Status == (int)DbConstant.InvoiceStatus.NotPrinted)
                .Select(i => i.Id).ToArray());
        }

        public List<InvoiceStatusItem> GetInvoiceStatusDropdownList()
        {
            List<InvoiceStatusItem> result = new List<InvoiceStatusItem>();
            result.Add(new InvoiceStatusItem
            {
                Status = 9,
                Description = "Semua"
            });

            result.Add(new InvoiceStatusItem
            {
                Status = (int)DbConstant.InvoiceStatus.FeeNotFixed,
                Description = "Belum Dibuat"
            });

            result.Add(new InvoiceStatusItem
            {
                Status = (int)DbConstant.InvoiceStatus.NotPrinted,
                Description = "Belum Dicetak"
            });

            result.Add(new InvoiceStatusItem
            {
                Status = (int)DbConstant.InvoiceStatus.Printed,
                Description = "Tercetak"
            });

            return result;
        }
    }
}
