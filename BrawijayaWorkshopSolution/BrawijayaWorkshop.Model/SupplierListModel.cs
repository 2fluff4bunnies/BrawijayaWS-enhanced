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
    public class SupplierListModel : AppBaseModel
    {
        private ISupplierRepository _supplierRepository;
        private IUnitOfWork _unitOfWork;

        public SupplierListModel(ISupplierRepository supplierRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _supplierRepository = supplierRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SupplierViewModel> SearchSupplier(string supplierName)
        {
            List<Supplier> result = _supplierRepository.GetMany(c => c.Name.Contains(supplierName) && c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.Name).ToList();
            List<SupplierViewModel> mappedResult = new List<SupplierViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteSupplier(SupplierViewModel supplier, int userID)
        {
            Supplier entity = _supplierRepository.GetById(supplier.Id);
            entity.ModifyUserId = userID;
            entity.ModifyDate = DateTime.Now;
            entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            _supplierRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
