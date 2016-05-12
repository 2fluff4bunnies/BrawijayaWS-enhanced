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
    public class SPKHistoryListModel : AppBaseModel
    {
        private ISPKRepository _SPKRepository;
        private IVehicleRepository _vehicleRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private ICustomerRepository _customerRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public SPKHistoryListModel(ISPKRepository SPKRepository, IReferenceRepository referenceRepository, ICustomerRepository customerRepository,
            IVehicleRepository vehicleRepository, IVehicleDetailRepository vehicleDetailRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _SPKRepository = SPKRepository;
            _vehicleRepository = vehicleRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _referenceRepository = referenceRepository;
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SPKViewModel> SearchSPK(string LicenseNumber, string code, int category, DateTime? dateFrom, DateTime? dateTo,
            int isContractWork, int customer)
        {
            List<SPK> result = _SPKRepository.GetMany(spk => spk.Status == (int)DbConstant.DefaultDataStatus.Active && spk.StatusCompletedId== (int) DbConstant.SPKCompletionStatus.Completed).ToList();

            if (dateFrom.HasValue && dateTo.HasValue)
            {
                result = result.Where(spk => spk.CreateDate.Date >= dateFrom && spk.CreateDate.Date <= dateTo).ToList();
            }

            if (!string.IsNullOrEmpty(LicenseNumber))
            {
                VehicleDetail vehicleDetail = _vehicleDetailRepository.GetMany(v => string.Compare(v.LicenseNumber, LicenseNumber, true) == 1
                                                                                    && v.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
                if (vehicleDetail != null)
                {
                    result = result.Where(spk => spk.VehicleId == vehicleDetail.VehicleId).ToList();
                }
            }

            if (customer > 0)
            {
                result = result.Where(spk => spk.Vehicle.CustomerId == customer).ToList();
            }

            if (!string.IsNullOrEmpty(code))
            {
                result = result.Where(spk => string.Compare(spk.Code, code, true) == 0).ToList();
            }

            if (category > 0)
            {
                result = result.Where(spk => spk.CategoryReferenceId == category).ToList();
            }

            if (isContractWork == 0)
            {
                result = result.Where(spk => spk.isContractWork == false).ToList();
            }

            if (isContractWork == 1)
            {
                result = result.Where(spk => spk.isContractWork == true).ToList();
            }

            List<SPKViewModel> mappedResult = new List<SPKViewModel>();

            return Map(result, mappedResult);
        }

        public List<ReferenceViewModel> GetSPKCategoryList()
        {
            Reference spkCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPKCATEGORY, true) == 0).FirstOrDefault();
            List<Reference> result = _referenceRepository.GetMany(r => r.ParentId == spkCategory.Id).ToList();

            result.Add(new Reference
            {
                Id = 0,
                Name = "Semua Kategori",
                Description = "Semua Kategori"
            });

            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();

            return Map(result, mappedResult);

        }

        public List<VehicleViewModel> GetSPKVehicleList()
        {
            List<Vehicle> result = _vehicleRepository.GetMany(v => v.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<VehicleViewModel> mappedResult = new List<VehicleViewModel>();
            return Map(result, mappedResult);
        }

        public List<CustomerViewModel> GetSPKCustomerList()
        {
            List<Customer> result = _customerRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            return Map(result, mappedResult);
        }
    }
}
