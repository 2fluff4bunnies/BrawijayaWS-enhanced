using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Model
{
    public class SPKListModel : BaseModel
    {
        private ISPKRepository _SPKRepository;
        private IVehicleRepository _vehicleRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public SPKListModel(ISPKRepository SPKRepository, IReferenceRepository referenceRepository,
            IVehicleRepository vehicleRepository, IUnitOfWork unitOfWork)
        {
            _SPKRepository = SPKRepository;
            _vehicleRepository = vehicleRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<Reference> GetSPKCategoryList()
        {
            Reference spkCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPKCATEGORY, true) == 0).FirstOrDefault();
            return _referenceRepository.GetMany(r => r.ParentId == spkCategory.Id).ToList();
        }

        public List<SPK> SearchSPK(string SPKCode, DbConstant.ApprovalStatus status)
        {
            List<SPK> result = _SPKRepository.GetMany(spk => string.Compare(spk.Code, SPKCode, true) == 0 && spk.Status == (int)status).ToList();
            return result;
        }
    }
}
