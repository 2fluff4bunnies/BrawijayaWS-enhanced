using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SPKDetailSparepartListModel : BaseModel
    {
        private ISPKRepository _SPKRepository;
        private ISPKDetailSparepartRepository _SPKDetailSparepartRepository;
        private ISPKDetailSparepartDetailRepository _SPKDetailSparepartDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IUnitOfWork _unitOfWork;

        public SPKDetailSparepartListModel(ISPKRepository SPKRepository, ISPKDetailSparepartRepository SPKDetailSparePartRepository,
            ISPKDetailSparepartDetailRepository SPKDetailSparepartDetailRepository, ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository, IUnitOfWork unitOfWork)
        {
            _SPKRepository = SPKRepository;
            _SPKDetailSparepartRepository = SPKDetailSparePartRepository;
            _SPKDetailSparepartDetailRepository = SPKDetailSparepartDetailRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<Sparepart> SearchSparepart(int categoryReferenceId, string name)
        {
            List<Sparepart> result = null;

            if (categoryReferenceId > 0)
            {
                result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.DefaultDataStatus.Active &&
                    sp.CategoryReferenceId == categoryReferenceId && sp.Name.Contains(name)).ToList();
            }
            else
            {
                result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.DefaultDataStatus.Active && sp.Name.Contains(name)).ToList();
            }

            return result;
        }

        public List<SparepartDetail> SearchSparepart(int sparepartId, DbConstant.SparepartDetailDataStatus status)
        {
            List<SparepartDetail> result = _sparepartDetailRepository.GetMany(
                spd => spd.SparepartId == sparepartId && spd.Status == (int)status).ToList();

            return result;
        }
    }
}
