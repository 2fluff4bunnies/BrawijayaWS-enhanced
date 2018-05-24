using BrawijayaWorkshop.Database;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;

namespace BrawijayaWorkshop.DataInitializerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //DataInitializer();
            DataImporter();
        }


        public static void DataImporter()
        {
            BrawijayaWorkshopDbContext contextTemp = new BrawijayaWorkshopDbContext(
                new MySqlConnection(ConfigurationManager.ConnectionStrings["TempConn"].ConnectionString), true);

            BrawijayaWorkshopDbContext contextDest = new BrawijayaWorkshopDbContext(
                new MySqlConnection(ConfigurationManager.ConnectionStrings["DestConn"].ConnectionString), true);
            contextDest.Database.CreateIfNotExists();

            //get all data from temp db
            List<ApplicationModul> ApplicationModulList = contextTemp.ApplicationModuls.ToList();
            List<Role> RoleList = contextTemp.Roles.ToList();
            List<Setting> SettingList = contextTemp.Settings.ToList();
            List<Reference> ReferenceList = contextTemp.References.ToList();
            List<User> UserList = contextTemp.Users.ToList();
            List<JournalMaster> JournalMasterList = contextTemp.JournalMasters.ToList();
            List<Brand> BrandList = contextTemp.Brands.ToList();
            List<BrawijayaWorkshop.Database.Entities.Type> TypeList = contextTemp.Types.ToList();
            List<City> CityList = contextTemp.Cities.ToList();

            List<RoleAccess> RoleAccessList = contextTemp.RoleAccesses.ToList();
            List<UserRole> UserRoleList = contextTemp.UserRoles.ToList();

            List<Customer> CustomerList = contextTemp.Customers.ToList();
            List<VehicleGroup> VehicleGroupList = contextTemp.VehicleGroups.ToList();
            List<Vehicle> VehicleList = contextTemp.Vehicles.ToList();
            List<VehicleDetail> VehicleDetailList = contextTemp.VehicleDetails.ToList();

            List<Mechanic> MechanicList = contextTemp.Mechanics.ToList();

            List<Supplier> SupplierList = contextTemp.Suppliers.ToList();
            List<Sparepart> SparepartList = contextTemp.Spareparts.ToList();
            //List<Sparepart> SpecialSparepartList = contextTemp.Wheels.ToList();

            List<SparepartManualTransaction> SparepartManualTransactionList = contextTemp.SparepartManualTransactions.ToList();
            List<Purchasing> PurchasingList = contextTemp.Purchasings.ToList();
            List<PurchasingDetail> PurchasingDetailList = contextTemp.PurchasingDetails.ToList();
            List<PurchaseReturn> PurchaseReturnList = contextTemp.PurchaseReturns.ToList();
            List<PurchaseReturnDetail> PurchaseReturnDetailList = contextTemp.PurchaseReturnDetails.ToList();

            List<SpecialSparepartDetail> SpecialSparepartDetailList = contextTemp.WheelDetails.ToList();
            List<VehicleWheel> VehicleWheelList = contextTemp.VehicleWheels.ToList();

            List<UsedGood> UsedGoodList = contextTemp.UsedGoods.ToList();
            List<UsedGoodTransaction> UsedGoodTransactionList = contextTemp.UsedGoodsTransactions.ToList();

            List<GuestBook> GuestBookList = contextTemp.GuestBooks.ToList();

            List<SPK> SPKList = contextTemp.SPKs.ToList();
            List<SPKDetailSparepart> SPKDetailSparepartList = contextTemp.SPKDetailSpareparts.ToList();
            List<SPKDetailSparepartDetail> SPKDetailSparepartDetailList = contextTemp.SPKDetailSparepartDetails.ToList();
            List<SPKSchedule> SPKScheduleList = contextTemp.SPKSchedules.ToList();
            List<WheelExchangeHistory> WheelExchangeHistoryList = contextTemp.WheelExchangeHistories.ToList();

            List<Invoice> InvoiceList = contextTemp.Invoices.ToList();
            List<InvoiceDetail> InvoiceDetailList = contextTemp.InvoiceDetails.ToList();
            List<SalesReturn> SalesReturnList = contextTemp.SalesReturns.ToList();
            List<SalesReturnDetail> SalesReturnDetailList = contextTemp.SalesReturnDetails.ToList();

            List<Transaction> TransactionList = contextTemp.Transactions.ToList();
            List<TransactionDetail> TransactionDetailList = contextTemp.TransactionDetails.ToList();

            List<BalanceJournal> BalanceJournalList = contextTemp.BalanceJournals.ToList();
            List<BalanceJournalDetail> BalanceJournalDetailList = contextTemp.BalanceJournalDetails.ToList();

            Dictionary<int, int> dictAppModul = new Dictionary<int, int>();
            Dictionary<int, int> dictRole = new Dictionary<int, int>();
            Dictionary<int, int> dictUser = new Dictionary<int, int>();
            Dictionary<int, int> dictCity = new Dictionary<int, int>();
            Dictionary<int, int> dictReference = new Dictionary<int, int>();
            Dictionary<int, int> dictJournalMaster = new Dictionary<int, int>();
            Dictionary<int, int> dictBrand = new Dictionary<int, int>();
            Dictionary<int, int> dictType = new Dictionary<int, int>();
            Dictionary<int, int> dictCustomer = new Dictionary<int, int>();
            Dictionary<int, int> dictVehicleGroup = new Dictionary<int, int>();
            Dictionary<int, int> dictVehicle = new Dictionary<int, int>();
            Dictionary<int, int> dictMechanic = new Dictionary<int, int>();
            Dictionary<int, int> dictSupplier = new Dictionary<int, int>();
            Dictionary<int, int> dictSparepart = new Dictionary<int, int>();
            Dictionary<int, int> dictSpecialSparepart = new Dictionary<int, int>();
            Dictionary<int, int> dictSpManualTrans = new Dictionary<int, int>();
            Dictionary<int, int> dictPurchasing = new Dictionary<int, int>();
            Dictionary<int, int> dictPurchasingDetail = new Dictionary<int, int>();
            Dictionary<int, int> dictPurchaseReturn = new Dictionary<int, int>();
            Dictionary<int, int> dictSparepartDetail = new Dictionary<int, int>();
            Dictionary<int, int> dictSpecialSparepartDetail = new Dictionary<int, int>();
            Dictionary<int, int> dictUsedGood = new Dictionary<int, int>();
            Dictionary<int, int> dictSPK = new Dictionary<int, int>();
            Dictionary<int, int> dictSPKDetailSparepart = new Dictionary<int, int>();
            Dictionary<int, int> dictSPKDetailSparepartDetail = new Dictionary<int, int>();
            Dictionary<int, int> dictInvoice = new Dictionary<int, int>();
            Dictionary<int, int> dictInvoiceDetail = new Dictionary<int, int>();
            Dictionary<int, int> dictSalesReturn = new Dictionary<int, int>();
            Dictionary<int, int> dictTransaction = new Dictionary<int, int>();
            Dictionary<int, int> dictBalanceJournal = new Dictionary<int, int>();

            //applicationmodul
            Console.Write("\nImporting table ApplicationModul");

            foreach (var item in ApplicationModulList)
            {
                int itemOldId = item.Id;
                item.Id = -1;
                ApplicationModul newItem = contextDest.ApplicationModuls.Add(item);
                contextDest.SaveChanges();

                dictAppModul.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table ApplicationModul done, " + ApplicationModulList.Count + " records imported");

            //role
            Console.Write("\nImporting table Role");

            foreach (var item in RoleList)
            {
                int itemOldId = item.Id;
                item.Id = -1;
                Role newItem = contextDest.Roles.Add(item);
                contextDest.SaveChanges();

                dictRole.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table Role done, " + RoleList.Count + " records imported");

            //setting
            Console.Write("\nImporting table setting");

            foreach (var item in SettingList)
            {
                contextDest.Settings.Add(item);
            }
            contextDest.SaveChanges();

            Console.Write("\nImporting table setting done, " + SettingList.Count + " records imported");

            //reference
            Console.Write("\nImporting table Reference");

            foreach (var item in ReferenceList)
            {
                int itemOldId = item.Id;
                Reference newItem = new Reference
                {
                    Id = -1,
                    Code = item.Code,
                    Description = item.Description,
                    Name = item.Name,
                    ParentId = item.ParentId,
                    Value = item.Value
                };

                if (item.ParentId > 0)
                {
                    int newParentId = dictReference[item.ParentId.Value];
                    newItem.ParentId = newParentId;
                }

                Reference insertedReference = contextDest.References.Add(newItem);
                contextDest.SaveChanges();

                dictReference.Add(itemOldId, insertedReference.Id);
            }

            Console.Write("\nImporting table Reference done, " + ReferenceList.Count + " records imported");

            //user
            Console.Write("\nImporting table User");

            foreach (var item in UserList)
            {
                int itemOldId = item.Id;
                item.Id = -1;
                User newItem = contextDest.Users.Add(item);
                contextDest.SaveChanges();

                dictUser.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table User done, " + UserList.Count + " records imported");

            //journalMaster
            Console.Write("\nImporting table JournalMaster");

            foreach (var item in JournalMasterList)
            {
                int itemOldId = item.Id;
                JournalMaster newItem = new JournalMaster
                {
                    Id = -1,
                    Code = item.Code,
                    Name = item.Name,
                    ParentId = item.ParentId,
                };

                if (item.ParentId > 0)
                {
                    int newParentId = dictJournalMaster[item.ParentId.Value];
                    newItem.ParentId = newParentId;
                }

                JournalMaster insertedJournalMaster = contextDest.JournalMasters.Add(newItem);
                contextDest.SaveChanges();

                dictJournalMaster.Add(itemOldId, insertedJournalMaster.Id);
            }

            Console.Write("\nImporting table JournalMaster done, " + JournalMasterList.Count + " records imported");

            //brand
            Console.Write("\nImporting table Brand");

            foreach (var item in BrandList)
            {
                int itemOldId = item.Id;
                item.Id = -1;
                Brand newItem = contextDest.Brands.Add(item);
                contextDest.SaveChanges();

                dictBrand.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table Brand done, " + BrandList.Count + " records imported");

            //type
            Console.Write("\nImporting table Type");

            foreach (var item in TypeList)
            {
                int itemOldId = item.Id;
                item.Id = -1;
                BrawijayaWorkshop.Database.Entities.Type newItem = contextDest.Types.Add(item);
                contextDest.SaveChanges();

                dictType.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table Type done, " + TypeList.Count + " records imported");

            //city
            Console.Write("\nImporting table City");

            foreach (var item in CityList)
            {
                int itemOldId = item.Id;
                item.Id = -1;
                City newItem = contextDest.Cities.Add(item);
                contextDest.SaveChanges();

                dictCity.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table City done, " + CityList.Count + " records imported");

            //role access
            Console.Write("\nImporting table RoleAccess");

            foreach (var item in RoleAccessList)
            {
                RoleAccess newItem = new RoleAccess();
                int role = dictRole[item.RoleId];
                int appModul = dictAppModul[item.ApplicationModulId];

                newItem.Id = -1;
                newItem.RoleId = role;
                newItem.ApplicationModulId = appModul;
                newItem.AccessCode = item.AccessCode;
                contextDest.RoleAccesses.Add(newItem);
            }
            contextDest.SaveChanges();

            Console.Write("\nImporting table RoleAccess done, " + RoleAccessList.Count + " records imported");

            //user role
            Console.Write("\nImporting table UserRole");

            foreach (var item in UserRoleList)
            {
                UserRole newItem = new UserRole();
                int role = dictRole[item.RoleId];
                int user = dictUser[item.UserId];

                newItem.Id = -1;
                newItem.RoleId = role;
                newItem.UserId = user;
                contextDest.UserRoles.Add(newItem);
            }

            Console.Write("\nImporting table UserRole done, " + UserRoleList.Count + " records imported");

            //customer
            Console.Write("\nImporting table Customer");

            foreach (var item in CustomerList)
            {
                int itemOldId = item.Id;
                Customer newItem = new Customer();
                int city = dictCity[item.CityId];
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.CityId = city;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.Address = item.Address;
                newItem.Code = item.Code;
                newItem.CompanyName = item.CompanyName;
                newItem.ContactPerson = item.ContactPerson;
                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.PhoneNumber = item.PhoneNumber;
                newItem.Status = item.Status;
                newItem = contextDest.Customers.Add(newItem);
                contextDest.SaveChanges();

                dictCustomer.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table Customer done, " + CustomerList.Count + " records imported");

            //vehicle group
            Console.Write("\nImporting table VehicleGroup");

            foreach (var item in VehicleGroupList)
            {
                int itemOldId = item.Id;
                VehicleGroup newItem = new VehicleGroup();
                int customer = dictCustomer[item.CustomerId];
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.CustomerId = customer;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Name = item.Name;
                newItem.Status = item.Status;
                newItem = contextDest.VehicleGroups.Add(newItem);
                contextDest.SaveChanges();

                dictVehicleGroup.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table VehicleGroup done, " + VehicleGroupList.Count + " records imported");

            //vehicle
            Console.Write("\nImporting table Vehicle");

            foreach (var item in VehicleList)
            {
                int itemOldId = item.Id;
                Vehicle newItem = new Vehicle();
                int customer = dictCustomer[item.CustomerId];
                int vehicleGroup = dictVehicleGroup[item.VehicleGroupId];
                int brand = dictBrand[item.BrandId];
                int type = dictType[item.TypeId];
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.CustomerId = customer;
                newItem.VehicleGroupId = vehicleGroup;
                newItem.BrandId = brand;
                newItem.TypeId = type;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.ActiveLicenseNumber = item.ActiveLicenseNumber;
                newItem.Code = item.Code;
                newItem.CreateDate = item.CreateDate;
                newItem.Kilometers = item.Kilometers;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;
                newItem.YearOfPurchase = item.YearOfPurchase;
                newItem = contextDest.Vehicles.Add(newItem);
                contextDest.SaveChanges();

                dictVehicle.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table Vehicle done, " + VehicleList.Count + " records imported");

            //vehicle detail
            Console.Write("\nImporting table VehicleDetail");

            foreach (var item in VehicleDetailList)
            {
                VehicleDetail newItem = new VehicleDetail();
                int vehicle = dictVehicle[item.VehicleId];
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.VehicleId = vehicle;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.CreateDate = item.CreateDate;
                newItem.ExpirationDate = item.ExpirationDate;
                newItem.LicenseNumber = item.LicenseNumber;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;
                contextDest.VehicleDetails.Add(newItem);
            }
            contextDest.SaveChanges();

            Console.Write("\nImporting table VehicleDetail done, " + VehicleDetailList.Count + " records imported");

            //mechanic
            Console.Write("\nImporting table Mechanic");

            foreach (var item in MechanicList)
            {
                int itemOldId = item.Id;
                Mechanic newItem = new Mechanic();
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.Address = item.Address;
                newItem.BaseFee = item.BaseFee;
                newItem.Code = item.Code;
                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Name = item.Name;
                newItem.PhoneNumber = item.PhoneNumber;
                newItem.Status = item.Status;
                newItem = contextDest.Mechanics.Add(newItem);
                contextDest.SaveChanges();

                dictMechanic.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table Mechanic done, " + MechanicList.Count + " records imported");

            //supplier
            Console.Write("\nImporting table Supplier");

            foreach (var item in SupplierList)
            {
                int itemOldId = item.Id;
                Supplier newItem = new Supplier();
                int city = dictCity[item.CityId];
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.CityId = city;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.Address = item.Address;
                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Name = item.Name;
                newItem.PhoneNumber = item.PhoneNumber;
                newItem.Status = item.Status;
                newItem = contextDest.Suppliers.Add(newItem);
                contextDest.SaveChanges();

                dictSupplier.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table Supplier done, " + SupplierList.Count + " records imported");

            //sparepart
            Console.Write("\nImporting table Sparepart");

            foreach (var item in SparepartList)
            {
                int itemOldId = item.Id;
                Sparepart newItem = new Sparepart();
                int category = dictReference[item.CategoryReferenceId];
                int unit = dictReference[item.UnitReferenceId];
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.CategoryReferenceId = category;
                newItem.UnitReferenceId = unit;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.Code = item.Code;
                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Name = item.Name;
                newItem.Status = item.Status;
                newItem.StockQty = item.StockQty;
                newItem = contextDest.Spareparts.Add(newItem);
                contextDest.SaveChanges();

                dictSparepart.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table Sparepart done, " + SparepartList.Count + " records imported");

            //sparepart manual trans
            Console.Write("\nImporting table SparepartManualTransaction");

            foreach (var item in SparepartManualTransactionList)
            {
                int itemOldId = item.Id;
                SparepartManualTransaction newItem = new SparepartManualTransaction();
                int sparepart = dictSparepart[item.SparepartId];
                int type = dictReference[item.UpdateTypeId];
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.SparepartId = sparepart;
                newItem.UpdateTypeId = type;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Price = item.Price;
                newItem.Qty = item.Qty;
                newItem.Remark = item.Remark;
                newItem.TransactionDate = item.TransactionDate;
                newItem = contextDest.SparepartManualTransactions.Add(newItem);
                contextDest.SaveChanges();

                dictSpManualTrans.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table SparepartManualTransaction done, " + SparepartManualTransactionList.Count + " records imported");

            //purchasing
            Console.Write("\nImporting table Purchasing");

            foreach (var item in PurchasingList)
            {
                int itemOldId = item.Id;
                Purchasing newItem = new Purchasing();
                int paymentMethod = dictReference[item.PaymentMethodId];
                int supplier = dictSupplier[item.SupplierId];
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.PaymentMethodId = paymentMethod;
                newItem.SupplierId = supplier;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.Code = item.Code;
                newItem.CreateDate = item.CreateDate;
                newItem.Date = item.Date;
                newItem.ModifyDate = item.ModifyDate;
                newItem.PaymentStatus = item.PaymentStatus;
                newItem.Status = item.Status;
                newItem.TotalHasPaid = item.TotalHasPaid;
                newItem.TotalPrice = item.TotalPrice;
                newItem = contextDest.Purchasings.Add(newItem);
                contextDest.SaveChanges();

                dictPurchasing.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table InvPurchasingoice done, " + PurchasingList.Count + " records imported");

            //purchasing detail
            Console.Write("\nImporting table PurchasingDetail");

            foreach (var item in PurchasingDetailList)
            {
                int itemOldId = item.Id;
                PurchasingDetail newItem = new PurchasingDetail();
                int purchasing = dictPurchasing[item.PurchasingId];
                int sparepart = dictSparepart[item.SparepartId];
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.PurchasingId = purchasing;
                newItem.SparepartId = sparepart;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Price = item.Price;
                newItem.Qty = item.Qty;
                newItem.SerialNumber = item.SerialNumber;
                newItem.Status = item.Status;
                newItem = contextDest.PurchasingDetails.Add(newItem);
                contextDest.SaveChanges();

                dictPurchasingDetail.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table PurchasingDetail done, " + PurchasingDetailList.Count + " records imported");

            //purchasing return
            Console.Write("\nImporting table PurchaseReturn");

            foreach (var item in PurchaseReturnList)
            {
                int itemOldId = item.Id;
                PurchaseReturn newItem = new PurchaseReturn();
                int purchasing = dictPurchasing[item.PurchasingId];
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.PurchasingId = purchasing;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.Code = item.Code;
                newItem.CreateDate = item.CreateDate;
                newItem.Date = item.Date;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;
                newItem = contextDest.PurchaseReturns.Add(newItem);
                contextDest.SaveChanges();

                dictPurchaseReturn.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table PurchaseReturn done, " + PurchaseReturnList.Count + " records imported");

            //purchasing return detail
            Console.Write("\nImporting table PurchaseReturnDetail");

            foreach (var item in PurchaseReturnDetailList)
            {
                int itemOldId = item.Id;
                PurchaseReturnDetail newItem = new PurchaseReturnDetail();
                int purchaseReturn = dictPurchaseReturn[item.PurchaseReturnId];
                if (item.PurchasingDetailId.HasValue && item.PurchasingDetailId != null && item.PurchasingDetailId > 0)
                {
                    int pDetail = dictPurchasingDetail[item.PurchasingDetailId.Value];
                    newItem.PurchasingDetailId = pDetail;
                }
                if (item.SparepartManualTransactionId.HasValue && item.SparepartManualTransactionId != null && item.SparepartManualTransactionId > 0)
                {
                    int spManualTrans = dictSpManualTrans[item.SparepartManualTransactionId.Value];
                    newItem.SparepartManualTransactionId = spManualTrans;
                } 
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.PurchaseReturnId = purchaseReturn;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;
                contextDest.PurchaseReturnDetails.Add(newItem);
            }
            contextDest.SaveChanges();

            Console.Write("\nImporting table PurchaseReturnDetail done, " + PurchaseReturnDetailList.Count + " records imported");

            //special sparepart detail
            Console.Write("\nImporting table SpecialSparepartDetail");

            foreach (var item in SpecialSparepartDetailList)
            {
                int itemOldId = item.Id;
                SpecialSparepartDetail newItem = new SpecialSparepartDetail();
                int ssp = dictSparepart[item.SparepartId];
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.SparepartId = ssp;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                if (item.PurchasingDetailId.HasValue && item.PurchasingDetailId != null && item.PurchasingDetailId > 0)
                {
                    int pDetail = dictPurchasingDetail[item.PurchasingDetailId.Value];
                    newItem.PurchasingDetailId = pDetail;
                }
                if (item.SparepartManualTransactionId.HasValue && item.SparepartManualTransactionId != null && item.SparepartManualTransactionId > 0)
                {
                    int spManualTrans = dictSpManualTrans[item.SparepartManualTransactionId.Value];
                    newItem.SparepartManualTransactionId = spManualTrans;
                }

                newItem.CreateDate = item.CreateDate;
                newItem.Kilometers = item.Kilometers;
                newItem.ModifyDate = item.ModifyDate;
                newItem.SerialNumber = item.SerialNumber;
                newItem.Status = item.Status;
                newItem = contextDest.WheelDetails.Add(newItem);
                contextDest.SaveChanges();

                dictSpecialSparepartDetail.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table SpecialSparepartDetail done, " + SpecialSparepartDetailList.Count + " records imported");

            //vehicle wheel
            Console.Write("\nImporting table VehicleWheel");

            foreach (var item in VehicleWheelList)
            {
                VehicleWheel newItem = new VehicleWheel();
                int vehicle = dictVehicle[item.VehicleId];
                int sspDetail = dictSpecialSparepartDetail[item.WheelDetailId];
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.VehicleId = vehicle;
                newItem.WheelDetailId = sspDetail;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Notes = item.Notes;
                newItem.Status = item.Status;
                contextDest.VehicleWheels.Add(newItem);
            }
            contextDest.SaveChanges();

            Console.Write("\nImporting table VehicleWheel done, " + VehicleWheelList.Count + " records imported");

            //used good
            Console.Write("\nImporting table UsedGood");

            foreach (var item in UsedGoodList)
            {
                int itemOldId = item.Id;
                UsedGood newItem = new UsedGood();
                int sparepart = dictSparepart[item.SparepartId];

                newItem.Id = -1;
                newItem.SparepartId = sparepart;

                newItem.Stock = item.Stock;
                newItem.Status = item.Status;
                newItem = contextDest.UsedGoods.Add(newItem);
                contextDest.SaveChanges();

                dictUsedGood.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table UsedGood done, " + UsedGoodList.Count + " records imported");

            //used good trans
            Console.Write("\nImporting table UsedGoodTransaction");

            foreach (var item in UsedGoodTransactionList)
            {
                UsedGoodTransaction newItem = new UsedGoodTransaction();
                int type = dictReference[item.TypeReferenceId];
                int usedGood = dictUsedGood[item.UsedGoodId];
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.TypeReferenceId = type;
                newItem.UsedGoodId = usedGood;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.CreateDate = item.CreateDate;
                newItem.ItemPrice = item.ItemPrice;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Qty = item.Qty;
                newItem.Remark = item.Remark;
                newItem.TotalPrice = item.TotalPrice;
                newItem.TransactionDate = item.TransactionDate;
                contextDest.UsedGoodsTransactions.Add(newItem);
            }
            contextDest.SaveChanges();

            Console.Write("\nImporting table UsedGoodTransaction done, " + UsedGoodTransactionList.Count + " records imported");

            //guest book
            Console.Write("\nImporting table GuestBook");

            foreach (var item in GuestBookList)
            {
                GuestBook newItem = new GuestBook();
                int vehicle = dictVehicle[item.VehicleId];
                int userCreate = dictUser[item.CreateUserId];
                int userModified = dictUser[item.ModifyUserId];

                newItem.Id = -1;
                newItem.VehicleId = vehicle;
                newItem.CreateUserId = userCreate;
                newItem.ModifyUserId = userModified;

                newItem.CreateDate = item.CreateDate;
                newItem.Description = item.Description;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;
                contextDest.GuestBooks.Add(newItem);
            }
            contextDest.SaveChanges();

            Console.Write("\nImporting table GuestBook done, " + GuestBookList.Count + " records imported");

            //SPK
            Console.Write("\nImporting table SPK");

            foreach (var item in SPKList)
            {
                int itemOldId = item.Id;

                SPK newItem = new SPK();

                newItem.Id = -1;
                newItem.VehicleId = dictVehicle[item.VehicleId];
                newItem.CreateUserId = dictUser[item.CreateUserId];
                newItem.ModifyUserId = dictUser[item.ModifyUserId];
                newItem.VehicleGroupId = dictVehicleGroup[item.VehicleGroupId];
                newItem.CategoryReferenceId = dictReference[item.CategoryReferenceId];

                if (item.SPKParentId > 0)
                {
                    newItem.SPKParentId = dictSPK[item.SPKParentId.Value];
                }

                newItem.Description = item.Description;
                newItem.Code = item.Code;
                newItem.isContractWork = item.isContractWork;
                newItem.Contractor = item.Contractor;
                newItem.ContractWorkFee = item.ContractWorkFee;
                newItem.DueDate = item.DueDate;
                newItem.Kilometers = item.Kilometers;
                newItem.StatusApprovalId = item.StatusApprovalId;
                newItem.StatusCompletedId = item.StatusCompletedId;
                newItem.StatusPrintId = item.StatusPrintId;
                newItem.StatusOverLimit = item.StatusOverLimit;
                newItem.Subtotal = item.Subtotal;
                newItem.TotalMechanicFee = item.TotalMechanicFee;
                newItem.TotalSparepartPrice = item.TotalSparepartPrice;
                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;

                SPK insertedSPK = contextDest.SPKs.Add(newItem);
                contextDest.SaveChanges();

                dictSPK.Add(itemOldId, insertedSPK.Id);
            }

            Console.Write("\nImporting table SPK done, " + SPKList.Count + " records imported");

            //spk detail sparepart
            Console.Write("\nImporting table SPKDetailSparepart");

            foreach (var item in SPKDetailSparepartList)
            {
                int itemOldId = item.Id;
                SPKDetailSparepart newItem = new SPKDetailSparepart();

                newItem.Id = -1;
                newItem.SparepartId = dictSparepart[item.SparepartId];
                newItem.SPKId = dictSPK[item.SPKId];
                newItem.CreateUserId = dictUser[item.CreateUserId];
                newItem.ModifyUserId = dictUser[item.ModifyUserId];

                newItem.TotalPrice = item.TotalPrice;
                newItem.TotalQuantity = item.TotalQuantity;
                newItem.TotalPriceAfterCommission = item.TotalPriceAfterCommission;
                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;
                newItem = contextDest.SPKDetailSpareparts.Add(newItem);
                contextDest.SaveChanges();

                dictSPKDetailSparepart.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table SPKDetailSparepart done, " + SPKDetailSparepartList.Count + " records imported");

            //spk detail sparepart detail
            Console.Write("\nImporting table SPKDetailSparepartDetail");

            foreach (var item in SPKDetailSparepartDetailList)
            {
                int itemOldId = item.Id;
                SPKDetailSparepartDetail newItem = new SPKDetailSparepartDetail();

                newItem.Id = -1;
                if (item.PurchasingDetailId.HasValue && item.PurchasingDetailId != null && item.PurchasingDetailId > 0)
                {
                    int pDetail = dictPurchasingDetail[item.PurchasingDetailId.Value];
                    newItem.PurchasingDetailId = pDetail;
                }
                if (item.SparepartManualTransactionId.HasValue && item.SparepartManualTransactionId != null && item.SparepartManualTransactionId > 0)
                {
                    int spManualTrans = dictSpManualTrans[item.SparepartManualTransactionId.Value];
                    newItem.SparepartManualTransactionId = spManualTrans;
                } 
                newItem.SPKDetailSparepartId = dictSPKDetailSparepart[item.SPKDetailSparepartId];
                newItem.CreateUserId = dictUser[item.CreateUserId];
                newItem.ModifyUserId = dictUser[item.ModifyUserId];

                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;
                newItem = contextDest.SPKDetailSparepartDetails.Add(newItem);
                contextDest.SaveChanges();

                dictSPKDetailSparepartDetail.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table SPKDetailSparepartDetail done, " + SPKDetailSparepartDetailList.Count + " records imported");

            //spk schedule
            Console.Write("\nImporting table SPKSchedule");

            foreach (var item in SPKScheduleList)
            {
                int itemOldId = item.Id;
                SPKSchedule newItem = new SPKSchedule();

                newItem.Id = -1;
                newItem.SPKId = dictSPK[item.SPKId];
                newItem.MechanicId = dictSPKDetailSparepart[item.MechanicId];
                newItem.CreateUserId = dictUser[item.CreateUserId];
                newItem.ModifyUserId = dictUser[item.ModifyUserId];

                newItem.Description = item.Description;
                newItem.Date = item.Date;
                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;
                newItem = contextDest.SPKSchedules.Add(newItem);
                contextDest.SaveChanges();
            }

            Console.Write("\nImporting table SPKSchedule done, " + SPKScheduleList.Count + " records imported");

            //wheel exchange history
            Console.Write("\nImporting table WheelExchangeHistory");

            foreach (var item in WheelExchangeHistoryList)
            {
                int itemOldId = item.Id;
                WheelExchangeHistory newItem = new WheelExchangeHistory();

                newItem.Id = -1;
                newItem.SPKId = dictSPK[item.SPKId];
                newItem.OriginalWheelId = dictSpecialSparepartDetail[item.OriginalWheelId];
                newItem.ReplaceWheelId = dictSpecialSparepartDetail[item.ReplaceWheelId];
                newItem.CreateUserId = dictUser[item.CreateUserId];
                newItem.ModifyUserId = dictUser[item.ModifyUserId];

                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;
                newItem = contextDest.WheelExchangeHistories.Add(newItem);
                contextDest.SaveChanges();
            }

            Console.Write("\nImporting table WheelExchangeHistory done, " + WheelExchangeHistoryList.Count + " records imported");

            //invoice
            Console.Write("\nImporting table Invoice");

            foreach (var item in InvoiceList)
            {
                int itemOldId = item.Id;
                Invoice newItem = new Invoice();

                newItem.Id = -1;
                newItem.SPKId = dictSPK[item.SPKId];
                newItem.PaymentMethodId = dictReference[item.PaymentMethodId];
                newItem.CreateUserId = dictUser[item.CreateUserId];
                newItem.ModifyUserId = dictUser[item.ModifyUserId];

                newItem.Code = item.Code;
                newItem.TotalPrice = item.TotalPrice;
                newItem.TotalHasPaid = item.TotalHasPaid;
                newItem.TotalService = item.TotalService;
                newItem.TotalFeeService = item.TotalFeeService;
                newItem.TotalServicePlusFee = item.TotalServicePlusFee;
                newItem.TotalSparepart = item.TotalSparepart;
                newItem.TotalFeeSparepart = item.TotalFeeSparepart;
                newItem.TotalSparepartPlusFee = item.TotalSparepartPlusFee;
                newItem.TotalValueAdded = item.TotalValueAdded;
                newItem.TotalSparepartAndService = item.TotalSparepartAndService;
                newItem.PaymentStatus = item.PaymentStatus;
                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;

                Invoice insertedInvoice = contextDest.Invoices.Add(newItem);
                contextDest.SaveChanges();

                dictInvoice.Add(itemOldId, insertedInvoice.Id);
            }

            Console.Write("\nImporting table Invoice done, " + InvoiceList.Count + " records imported");

            //invoice detail
            Console.Write("\nImporting table InvoiceDetail");

            foreach (var item in InvoiceDetailList)
            {
                int itemOldId = item.Id;
                InvoiceDetail newItem = new InvoiceDetail();

                newItem.Id = -1;
                newItem.InvoiceId = dictInvoice[item.InvoiceId];
                newItem.SPKDetailSparepartDetailId = dictReference[item.SPKDetailSparepartDetailId];
                newItem.CreateUserId = dictUser[item.CreateUserId];
                newItem.ModifyUserId = dictUser[item.ModifyUserId];

                newItem.FeePctg = item.FeePctg;
                newItem.SubTotalPrice = item.SubTotalPrice;
                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;

                newItem = contextDest.InvoiceDetails.Add(newItem);
                contextDest.SaveChanges();

                dictInvoiceDetail.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table InvoiceDetail done, " + InvoiceDetailList.Count + " records imported");

            //sales return
            Console.Write("\nImporting table SalesReturn");

            foreach (var item in SalesReturnList)
            {
                int itemOldId = item.Id;
                SalesReturn newItem = new SalesReturn();

                newItem.Id = -1;
                newItem.InvoiceId = dictInvoice[item.InvoiceId];
                newItem.CreateUserId = dictUser[item.CreateUserId];
                newItem.ModifyUserId = dictUser[item.ModifyUserId];

                newItem.Code = item.Code;
                newItem.Date = item.Date;
                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;

                newItem = contextDest.SalesReturns.Add(newItem);
                contextDest.SaveChanges();

                dictSalesReturn.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table SalesReturn done, " + SalesReturnList.Count + " records imported");

            //sales return detail
            Console.Write("\nImporting table SalesReturnDetail");

            foreach (var item in SalesReturnDetailList)
            {
                int itemOldId = item.Id;
                SalesReturnDetail newItem = new SalesReturnDetail();

                newItem.Id = -1;
                newItem.SalesReturnId = dictSalesReturn[item.SalesReturnId];
                newItem.InvoiceDetailId = dictInvoiceDetail[item.InvoiceDetailId];
                newItem.CreateUserId = dictUser[item.CreateUserId];
                newItem.ModifyUserId = dictUser[item.ModifyUserId];

                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;

                newItem = contextDest.SalesReturnDetails.Add(newItem);
                contextDest.SaveChanges();
            }

            Console.Write("\nImporting table SalesReturnDetail done, " + SalesReturnDetailList.Count + " records imported");

            //transaction
            Console.Write("\nImporting table Transaction");

            foreach (var item in TransactionList)
            {
                int itemOldId = item.Id;
                Transaction newItem = new Transaction();

                newItem.Id = -1;
                newItem.ReferenceTableId = dictReference[item.ReferenceTableId];
                newItem.PaymentMethodId = dictReference[item.PaymentMethodId.Value];
                newItem.CreateUserId = dictUser[item.CreateUserId];
                newItem.ModifyUserId = dictUser[item.ModifyUserId];

                newItem.PrimaryKeyValue = item.PrimaryKeyValue;
                newItem.TotalTransaction = item.TotalTransaction;
                newItem.TotalPayment = item.TotalPayment;
                newItem.Description = item.Description;
                newItem.IsReconciliation = item.IsReconciliation;
                newItem.TransactionDate = item.TransactionDate;
                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;

                newItem = contextDest.Transactions.Add(newItem);
                contextDest.SaveChanges();

                dictTransaction.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table Transaction done, " + TransactionList.Count + " records imported");

            //transaction detail
            Console.Write("\nImporting table TransactionDetail");

            foreach (var item in TransactionDetailList)
            {
                int itemOldId = item.Id;

                TransactionDetail newItem = new TransactionDetail();

                newItem.Id = -1;
                newItem.JournalId = dictJournalMaster[item.JournalId];
                newItem.ParentId = dictTransaction[item.ParentId];
                //newItem.CreateUserId = dictUser[item.CreateUserId];
                //newItem.ModifyUserId = dictUser[item.ModifyUserId];

                //newItem.CreateDate = item.CreateDate;
                //newItem.ModifyDate = item.ModifyDate;
                //newItem.Status = item.Status;

                newItem = contextDest.TransactionDetails.Add(newItem);
                contextDest.SaveChanges();
            }

            Console.Write("\nImporting table TransactionDetail done, " + TransactionDetailList.Count + " records imported");

            //balance journal
            Console.Write("\nImporting table BalanceJournal");

            foreach (var item in BalanceJournalList)
            {
                int itemOldId = item.Id;
                BalanceJournal newItem = new BalanceJournal();

                newItem.Id = -1;
                newItem.CreateUserId = dictUser[item.CreateUserId];
                newItem.ModifyUserId = dictUser[item.ModifyUserId];

                newItem.Month = item.Month;
                newItem.Year = item.Year;
                newItem.IsFirst = item.IsFirst;
                newItem.CreateDate = item.CreateDate;
                newItem.ModifyDate = item.ModifyDate;
                newItem.Status = item.Status;

                newItem = contextDest.BalanceJournals.Add(newItem);
                contextDest.SaveChanges();

                dictBalanceJournal.Add(itemOldId, newItem.Id);
            }

            Console.Write("\nImporting table BalanceJournal done, " + BalanceJournalList.Count + " records imported");

            //balance journal detail 
            Console.Write("\nImporting table BalanceJournalDetail");

            foreach (var item in BalanceJournalDetailList)
            {
                int itemOldId = item.Id;
                BalanceJournalDetail newItem = new BalanceJournalDetail();

                newItem.Id = -1;
                newItem.JournalId = dictJournalMaster[item.JournalId];
                newItem.ParentId = dictBalanceJournal[item.ParentId];
                //newItem.CreateUserId = dictUser[item.CreateUserId];
                //newItem.ModifyUserId = dictUser[item.ModifyUserId];

                newItem.FirstDebit = item.FirstDebit;
                newItem.FirstCredit = item.FirstCredit;
                newItem.MutationDebit = item.MutationDebit;
                newItem.MutationCredit = item.MutationCredit;
                newItem.BalanceAfterMutationDebit = item.BalanceAfterMutationDebit;
                newItem.BalanceAfterMutationCredit = item.BalanceAfterMutationCredit;
                newItem.ReconciliationDebit = item.ReconciliationDebit;
                newItem.ReconciliationCredit = item.ReconciliationCredit;
                newItem.BalanceAfterReconciliationDebit = item.BalanceAfterReconciliationDebit;
                newItem.BalanceAfterReconciliationCredit = item.BalanceAfterReconciliationCredit;
                newItem.ProfitLossDebit = item.ProfitLossDebit;
                newItem.ProfitLossCredit = item.ProfitLossCredit;
                newItem.LastDebit = item.LastDebit;
                newItem.LastCredit = item.LastCredit;
                //newItem.CreateDate = item.CreateDate;
                //newItem.ModifyDate = item.ModifyDate;
                //newItem.Status = item.Status;

                newItem = contextDest.BalanceJournalDetails.Add(newItem);
                contextDest.SaveChanges();
            }

            Console.Write("\nImporting table BalanceJournalDetail done, " + BalanceJournalDetailList.Count + " records imported");

            Console.Write("MOTHA FUCKIN DONE!");
            Console.Read();
        }



        public static void DataInitializer()
        {
            string dirPath = "D:/Documents/Bengkel App/Data/";
            string accFile = "Account Jurnal.xlsx";
            string invFile = "Inv.xlsx";
            string citFile = "City.xlsx";
            string balJournal = "BalanceJournal.xlsx";

            try
            {
                // todo: read excel inventory and acc and insert into temporary table
                DataTable resultInv = DataExportImportUtils.CreateDataTableFromExcel(dirPath + invFile, true);
                DataTable resultAcc = DataExportImportUtils.CreateDataTableFromExcel(dirPath + accFile, true);
                DataTable resultCit = DataExportImportUtils.CreateDataTableFromExcel(dirPath + citFile, true);
                DataTable resultCatJournal = DataExportImportUtils.CreateDataTableFromExcel(dirPath + balJournal, true);

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"CREATE TABLE `temp_catjournal` (
                                          `Code` varchar(100) DEFAULT NULL,
                                          `Name` varchar(100) DEFAULT NULL,
                                          `Description` varchar(100) DEFAULT NULL,
                                          `Value` varchar(100) DEFAULT NULL,
                                          `Parent` varchar(100) DEFAULT NULL
                                        ) ENGINE=InnoDB DEFAULT CHARSET=utf8;";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                }
                catch (Exception ex)
                {
                    if (ex != null) { }
                    // do nothing
                }

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"CREATE TABLE `temp_cit` (
                                          `Id` varchar(100) DEFAULT NULL,
                                          `Code` varchar(100) DEFAULT NULL,
                                          `Name` varchar(100) DEFAULT NULL
                                        ) ENGINE=InnoDB DEFAULT CHARSET=utf8;";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                }
                catch (Exception ex)
                {
                    if (ex != null) { }
                    // do nothing
                }

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"CREATE TABLE `temp_inv` (
                                          `Kode` varchar(100) DEFAULT NULL,
                                          `Nama` varchar(100) DEFAULT NULL,
                                          `Qmin` double DEFAULT NULL,
                                          `Unit` varchar(10) DEFAULT NULL,
                                          `Chusr` int(11) DEFAULT NULL,
                                          `Chtime` varchar(100) DEFAULT NULL,
                                          `Jenis` varchar(100) DEFAULT NULL,
                                          `Price` double DEFAULT NULL,
                                          `ACC` varchar(45) DEFAULT NULL,
                                          `LAMA` int(11) DEFAULT NULL
                                        ) ENGINE=InnoDB DEFAULT CHARSET=utf8;";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                }
                catch (Exception ex)
                {
                    if (ex != null) { }
                    // do nothing
                }

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"CREATE TABLE `temp_acc` (
                                          `Kode` varchar(100) DEFAULT NULL,
                                          `Nama` varchar(100) DEFAULT NULL,
                                          `Induk` varchar(100) DEFAULT NULL
                                        ) ENGINE=InnoDB DEFAULT CHARSET=utf8;";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                }
                catch (Exception ex)
                {
                    if (ex != null) { }
                    // do nothing
                }

                if (resultCatJournal != null)
                {
                    resultCatJournal.ExportDataTableToCsv(dirPath + "catjournal.csv");

                    // insert into database
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        conn.Open();

                        MySqlBulkLoader loader = new MySqlBulkLoader(conn);
                        loader.TableName = "temp_catjournal";
                        loader.FieldTerminator = "\t";
                        loader.LineTerminator = "\n";
                        loader.FileName = dirPath + "catjournal.csv";
                        loader.NumberOfLinesToSkip = 1;
                        int inserted = loader.Load();
                        Console.WriteLine("Total rows: " + inserted);

                        conn.Close();
                    }

                    // insert into database main ref
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"INSERT INTO `references` (`Code`, `Name`, `Description`, `Value`, `ParentId`)
                                            SELECT REPLACE(REPLACE(`code`, '\r', ''), '\n', ''), `Name`, `Description`, `Value`,
                                            (SELECT `Id` FROM `references` WHERE `Code`=REPLACE(REPLACE(`parent`, '\r', ''), '\n', ''))
                                            FROM temp_catjournal";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                    //                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    //                    {
                    //                        MySqlCommand cmd = conn.CreateCommand();
                    //                        cmd.CommandText = @"UPDATE `references` a
                    //                                            SET a.ParentId = (SELECT z.Id FROM (SELECT x.*, y.Code `Kode` FROM `references` x, temp_catjournal y WHERE x.Code=y.Parent) z WHERE z.Kode=a.Code)";
                    //                        cmd.CommandType = CommandType.Text;
                    //                        conn.Open();
                    //                        cmd.ExecuteNonQuery();
                    //                        conn.Clone();
                    //                    }
                }

                if (resultCit != null)
                {
                    resultCit.ExportDataTableToCsv(dirPath + "city.csv");

                    // insert into database
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        conn.Open();

                        MySqlBulkLoader loader = new MySqlBulkLoader(conn);
                        loader.TableName = "temp_cit";
                        loader.FieldTerminator = "\t";
                        loader.LineTerminator = "\n";
                        loader.FileName = dirPath + "city.csv";
                        loader.NumberOfLinesToSkip = 1;
                        int inserted = loader.Load();
                        Console.WriteLine("Total rows: " + inserted);

                        conn.Close();
                    }

                    // insert into database city
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"INSERT INTO cities (`Code`, `Name`)
                                            SELECT `Code`, `Name`
                                            FROM temp_cit";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                }

                if (resultInv != null)
                {
                    // fix typing error
                    foreach (DataRow iRow in resultInv.Rows)
                    {
                        if (iRow["Kode"].ToString().Contains("["))
                        {
                            iRow["Kode"] = iRow["Kode"].ToString().Replace("[", "");
                        }
                        if (iRow["Unit"].ToString().Contains("PV"))
                        {
                            iRow["Unit"] = "PC";
                        }
                    }

                    // convert to csv
                    resultInv.ExportDataTableToCsv(dirPath + "inv.csv");

                    // insert into database
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        conn.Open();

                        MySqlBulkLoader loader = new MySqlBulkLoader(conn);
                        loader.TableName = "temp_inv";
                        loader.FieldTerminator = "\t";
                        loader.LineTerminator = "\n";
                        loader.FileName = dirPath + "inv.csv";
                        loader.NumberOfLinesToSkip = 1;
                        int inserted = loader.Load();
                        Console.WriteLine("Total rows: " + inserted);

                        conn.Close();
                    }

                    // generate main sparepart data
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"INSERT INTO spareparts (`Code`, `Name`, `StockQty`, `UnitReferenceId`, `CategoryReferenceId`, `CreateDate`, `CreateUserId`, `ModifyDate`, `ModifyUserId`, `Status`)
                                            SELECT Kode, Nama, 0,
                                            IFNULL((SELECT a.`Id` FROM `references` a WHERE a.`ParentId`=(SELECT Id FROM `references` WHERE Code='REF_SPAREPARTUNIT') AND a.`Code`=Unit),
                                            (SELECT a.`Id` FROM `references` a WHERE a.`ParentId`=(SELECT Id FROM `references` WHERE Code='REF_SPAREPARTUNIT') AND a.`Code`='-')),
                                            IFNULL((SELECT a.`Id` FROM `references` a WHERE a.`ParentId`=(SELECT Id FROM `references` WHERE Code='REF_SPAREPARTCATEGORY') AND a.`Code`=SUBSTR(Kode, 1, LENGTH(a.`Code`))),
                                            (SELECT a.`Id` FROM `references` a WHERE a.`ParentId`=(SELECT Id FROM `references` WHERE Code='REF_SPAREPARTCATEGORY') AND a.`Code`='-')),
                                            current_date(), (SELECT Id FROM users WHERE UserName='superadmin'),
                                            current_date(), (SELECT Id FROM users WHERE UserName='superadmin'), 1
                                            FROM temp_inv";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }

                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "DELETE FROM temp_inv";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                }

                if (resultAcc != null)
                {
                    foreach (DataRow row in resultAcc.Rows)
                    {
                        row["Kode"] = row["Kode"].ToString().Trim();
                        try
                        {
                            row["Induk"] = row["Induk"].ToString();
                        }
                        catch { }
                    }

                    // convert to csv
                    resultAcc.ExportDataTableToCsv(dirPath + "acc.csv");

                    // insert into database
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        conn.Open();

                        MySqlBulkLoader loader = new MySqlBulkLoader(conn);
                        loader.TableName = "temp_acc";
                        loader.FieldTerminator = "\t";
                        loader.LineTerminator = "\n";
                        loader.FileName = dirPath + "acc.csv";
                        loader.NumberOfLinesToSkip = 1;
                        int inserted = loader.Load();
                        Console.WriteLine("Total rows: " + inserted);

                        conn.Close();
                    }

                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"UPDATE temp_acc SET Induk=REPLACE(REPLACE(Induk, '\r', ''), '\n', '')";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }

                    // generate main account data
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"INSERT INTO journalmasters (`Code`, `Name`, `ParentId`)
                                            SELECT `Kode`, `Nama`,
                                            (SELECT a.Id FROM journalmasters a, temp_acc b WHERE a.Code=b.Induk)
                                            FROM temp_acc";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"UPDATE journalmasters a
                                            SET a.ParentId = (SELECT z.Id FROM (SELECT x.*, y.Kode FROM journalmasters x, temp_acc y WHERE x.Code=y.Induk) z WHERE z.Kode=a.Code)";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                }

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = @"DROP TABLE temp_catjournal";
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Clone();
                }

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = @"DROP TABLE temp_cit";
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Clone();
                }

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = @"DROP TABLE temp_inv";
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Clone();
                }

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = @"DROP TABLE temp_acc";
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Clone();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
