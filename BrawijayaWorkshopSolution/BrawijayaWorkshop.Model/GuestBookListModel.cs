using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class GuestBookListModel : AppBaseModel
    {
        private IGuestBookRepository _guestBookRepository;
        private IVehicleRepository _vehicleRepository;
        private IUnitOfWork _unitOfWork;

        public GuestBookListModel(IGuestBookRepository guestBookRepository, 
            IVehicleRepository vehicleRepository, IUnitOfWork unitOfWork)
        {
            _guestBookRepository = guestBookRepository;
            _vehicleRepository = vehicleRepository;
            _unitOfWork = unitOfWork;
        }

        public List<GuestBookViewModel> SearchGuestBook(string licenseNumber)
        {
            List<GuestBook> result = _guestBookRepository.GetMany(gb => gb.Vehicle.ActiveLicenseNumber.Contains(licenseNumber) &&
                gb.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.CreateDate).ToList();
            List<GuestBookViewModel> mappedResult = new List<GuestBookViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteGuestBook(GuestBookViewModel GuestBook)
        {
            GuestBook entity = _guestBookRepository.GetById(GuestBook.Id);
            entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            _guestBookRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
