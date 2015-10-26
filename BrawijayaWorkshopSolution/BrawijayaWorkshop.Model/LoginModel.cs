using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class LoginModel : BaseModel
    {
        private IUserRepository _userRepository;
        private IUserRoleRepository _userRoleRepository;
        private IRoleAccessRepository _roleAccessRepository;

        public LoginModel(IUserRepository userRepository,
            IUserRoleRepository userRoleRepository, IRoleAccessRepository roleAccessRepository)
        {
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _roleAccessRepository = roleAccessRepository;
        }

        public User ValidateLogin(string userName, string password)
        {
            User result = _userRepository.GetMany(u => string.Compare(userName, u.UserName, true) == 0 &&
                string.Compare(password, u.Password, false) == 0).FirstOrDefault();
            return result;
        }

        public UserRole GetUserRolesByUserId(int userId)
        {
            return _userRoleRepository.GetMany(ur => ur.UserId == userId).FirstOrDefault();
        }

        public List<RoleAccess> GetRoleAccessByRoleId(int roleId)
        {
            return _roleAccessRepository.GetMany(ra => ra.RoleId == roleId).ToList();
        }
    }
}
