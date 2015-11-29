using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class MechanicListModel : BaseModel
    {
        private IMechanicRepository _MechanicRepository;
        private IUnitOfWork _unitOfWork;

        public MechanicListModel(IMechanicRepository MechanicRepository, IUnitOfWork unitOfWork)
        {
            _MechanicRepository = MechanicRepository;
            _unitOfWork = unitOfWork;
        }

        public List<Mechanic> SearchMechanic(string MechanicName)
        {
            return _MechanicRepository.GetMany(c => c.Name.Contains(MechanicName)).OrderBy(c => c.Name).ToList();
        }

        public void DeleteMechanic(Mechanic Mechanic)
        {
            _MechanicRepository.Delete(Mechanic);
            _unitOfWork.SaveChanges();
        }
    }
}
