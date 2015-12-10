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
    public class SPKDetailMechanicListModel : BaseModel
    {
        private ISPKRepository _SPKRepository;
        private ISPKDetailMechanicRepository _SPKDetailMechanicRepository;
        private IMechanicRepository _mechanicRepository;
        private IUnitOfWork _unitOfWork;

        public SPKDetailMechanicListModel(ISPKRepository SPKRepository, ISPKDetailMechanicRepository SPKDetailMechanicRepository,
            IMechanicRepository mechanicRepository, IUnitOfWork unitOfWork)
        {
            _SPKRepository = SPKRepository;
            _SPKDetailMechanicRepository = SPKDetailMechanicRepository;
            _mechanicRepository = mechanicRepository;
            _unitOfWork = unitOfWork;
        }

        public List<Mechanic> SearchMechanic(int mechanicId)
        {
#warning TODO find mechanic that present

            List<Mechanic> result = _mechanicRepository.GetMany(
                m => m.Id == mechanicId).ToList();

            return result;
        }

    }
}
