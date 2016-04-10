using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace BrawijayaWorkshop.Model
{
    public class LoginModel : AppBaseModel
    {
        private IUserRepository _userRepository;
        private IUserRoleRepository _userRoleRepository;
        private IRoleAccessRepository _roleAccessRepository;

        public LoginModel(IUserRepository userRepository,
            IUserRoleRepository userRoleRepository, IRoleAccessRepository roleAccessRepository)
            : base()
        {
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _roleAccessRepository = roleAccessRepository;
        }

        public UserViewModel ValidateLogin(string userName, string password)
        {
            User result = _userRepository.GetMany(u => string.Compare(userName, u.UserName, true) == 0 &&
                string.Compare(password, u.Password, false) == 0 && u.IsActive).FirstOrDefault();
            UserViewModel mappedResult = new UserViewModel();
            return Map(result, mappedResult);
        }

        public UserRoleViewModel GetUserRolesByUserId(int userId)
        {
            UserRole result = _userRoleRepository.GetMany(ur => ur.UserId == userId).FirstOrDefault();
            UserRoleViewModel mappedResult = new UserRoleViewModel();
            return Map(result, mappedResult);
        }

        public List<RoleAccessViewModel> GetRoleAccessByRoleId(int roleId)
        {
            List<RoleAccess> result = _roleAccessRepository.GetMany(ra => ra.RoleId == roleId).ToList();
            List<RoleAccessViewModel> mappedResult = new List<RoleAccessViewModel>();
            return Map(result, mappedResult);
        }
    }
}
