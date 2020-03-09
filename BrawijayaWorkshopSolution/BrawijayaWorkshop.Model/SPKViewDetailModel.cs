using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Model
{
    public class SPKViewDetailModel : SPKBaseModel
    {
        private ISettingRepository _settingRepository;
        private IReferenceRepository _referenceRepository;
        private IVehicleRepository _vehicleRepository;
        private ISPKRepository _SPKRepository;
        private ISPKDetailSparepartRepository _SPKDetailSparepartRepository;
        private ISPKDetailSparepartDetailRepository _SPKDetailSparepartDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private IUsedGoodRepository _usedGoodRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private IVehicleWheelRepository _vehicleWheelRepository;
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private IWheelExchangeHistoryRepository _wheelExchangeHistoryRepository;
        private ISPKScheduleRepository _SPKScheduleRepository;
        private ISparepartStockCardRepository _sparepartStokCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStokCardDetailRepository;
        private IVehicleGroupRepository _vehicleGroupRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISparepartManualTransactionRepository _sparepartManualTransactionRepository;
        private ICustomerRepository _customerRepository;
        private IBrandRepository _brandRepository;
        private IMechanicRepository _mechanicRepository;
        private IUnitOfWork _unitOfWork;

        public SPKViewDetailModel(ISettingRepository settingRepository, IReferenceRepository referenceRepository, IVehicleRepository vehicleRepository,
            ISPKRepository SPKRepository, ISPKDetailSparepartRepository SPKDetailSparePartRepository,
            ISPKDetailSparepartDetailRepository SPKDetailSparepartDetailRepository, ISparepartRepository sparepartRepository,
            IUsedGoodRepository usedGoodRepository,
            IUsedGoodTransactionRepository usedGoodTransactionRepository,
            ISpecialSparepartDetailRepository specialSparepartDetailRepository,
            IVehicleWheelRepository vehicleWheelRepository,
            IInvoiceRepository invoiceRepository,
            IInvoiceDetailRepository invoiceDetailRepository,
            IWheelExchangeHistoryRepository WheelExchangeHistoryRepository,
            ISPKScheduleRepository spkScheduleRepository,
            ISparepartStockCardRepository sparepartStokCardRepository,
            ISparepartStockCardDetailRepository sparepartStokCardDetailRepository,
            IVehicleGroupRepository vehicleGroupRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartManualTransactionRepository sparepartManualTransaction,
            ICustomerRepository customerRepository,
            IBrandRepository brandRepository,
            IMechanicRepository mechanicRepository,
            IUnitOfWork unitOfWork)
            : base(
                 settingRepository,
                 referenceRepository,
                 vehicleRepository,
                 SPKRepository,
                 SPKDetailSparePartRepository,
                 SPKDetailSparepartDetailRepository,
                 sparepartRepository,
                 usedGoodRepository,
                 usedGoodTransactionRepository,
                 specialSparepartDetailRepository,
                 vehicleWheelRepository,
                 invoiceRepository,
                 invoiceDetailRepository,
                 WheelExchangeHistoryRepository,
                 spkScheduleRepository,
                 sparepartStokCardRepository,
                 sparepartStokCardDetailRepository,
                 vehicleGroupRepository,
                 purchasingDetailRepository,
                 sparepartManualTransaction,
                 customerRepository,
                 brandRepository,
                 mechanicRepository,
                 unitOfWork
            )
        {
            _settingRepository = settingRepository;
            _referenceRepository = referenceRepository;
            _vehicleRepository = vehicleRepository;
            _SPKRepository = SPKRepository;
            _SPKDetailSparepartRepository = SPKDetailSparePartRepository;
            _SPKDetailSparepartDetailRepository = SPKDetailSparepartDetailRepository;
            _sparepartRepository = sparepartRepository;
            _usedGoodRepository = usedGoodRepository;
            _specialSparepartDetailRepository = specialSparepartDetailRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _SPKScheduleRepository = spkScheduleRepository;
            _wheelExchangeHistoryRepository = WheelExchangeHistoryRepository;
            _sparepartStokCardRepository = sparepartStokCardRepository;
            _sparepartStokCardDetailRepository = sparepartStokCardDetailRepository;
            _vehicleGroupRepository = vehicleGroupRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _sparepartManualTransactionRepository = sparepartManualTransaction;
            _customerRepository = customerRepository;
            _brandRepository = brandRepository;
            _mechanicRepository = mechanicRepository;
            _unitOfWork = unitOfWork;
        }

    }
}