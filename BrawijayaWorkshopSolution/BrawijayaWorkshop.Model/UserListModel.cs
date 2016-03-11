using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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

        public List<UserViewModel> SearchUser(int senderUserId, string name, bool isActive = true)
        {
            Expression<Func<User, bool>> where = ur => (ur.FirstName.Contains(name) ||
                              ur.LastName.Contains(name) ||
                              ur.UserName.Contains(name)) &&
                              string.Compare(ur.UserName, "superadmin", true) != 0 &&
                              ur.Id != senderUserId;
            List<User> result = _userRepository.GetMany(where).ToList();
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