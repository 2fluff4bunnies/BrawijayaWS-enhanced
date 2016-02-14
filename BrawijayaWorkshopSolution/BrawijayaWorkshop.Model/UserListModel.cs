using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class UserListModel : AppBaseModel
    {
        private IUserRepository _userRepository;
        private IUnitOfWork _unitOfWork;

        public UserListModel(IUserRepository userRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public List<UserViewModel> SearchUser(string name, bool isActive = true)
        {
            List<User> result = _userRepository.GetMany(u =>
                (u.FirstName.Contains(name) || u.LastName.Contains(name)) && u.IsActive == isActive).ToList();
            List<UserViewModel> mappedResult = new List<UserViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteUser(int userId)
        {
            User entity = _userRepository.GetById(userId);
            entity.IsActive = false;
            _userRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}