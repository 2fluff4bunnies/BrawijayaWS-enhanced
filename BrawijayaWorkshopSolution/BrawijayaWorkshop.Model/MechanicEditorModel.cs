using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class MechanicEditorModel : BaseModel
    {
        private IMechanicRepository _MechanicRepository;
        private IUnitOfWork _unitOfWork;

        public MechanicEditorModel(IMechanicRepository MechanicRepository, IUnitOfWork unitOfWork)
        {
            _MechanicRepository = MechanicRepository;
            _unitOfWork = unitOfWork;
        }

        public void InsertMechanic(Mechanic Mechanic)
        {
            _MechanicRepository.Add(Mechanic);
            _unitOfWork.SaveChanges();
        }

        public void UpdateMechanic(Mechanic Mechanic)
        {
            _MechanicRepository.Update(Mechanic);
            _unitOfWork.SaveChanges();
        }
    }
}
