using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class UserRoleEditorModel : AppBaseModel
    {
        private IUserRepository _userRepository;
        private IRoleRepository _roleRepository;
        private IUserRoleRepository _userRoleRepository;
        private IUnitOfWork _unitOfWork;

        public UserRoleEditorModel(IUserRepository userRepository,
                                   IRoleRepository roleRepository,
                                   IUserRoleRepository userRoleRepository,
                                   IUnitOfWork unitOfWork)
            : base()
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _userRoleRepository = userRoleRepository;
            _unitOfWork = unitOfWork;
        }

        public List<UserViewModel> RetrieveAllUser()
        {
            List<User> result = _userRepository.GetMany(u => string.Compare(u.UserName, "superadmin", true) != 0).ToList();
            List<UserViewModel> mappedResult = new List<UserViewModel>();
            return Map(result, mappedResult);
        }

        public List<RoleViewModel> RetrieveAllRole()
        {
            List<Role> result = _roleRepository.GetAll().ToList();
            List<RoleViewModel> mappedResult = new List<RoleViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertUserRole(UserRoleViewModel userRole)
        {
            if (Validate(userRole.UserId, userRole.RoleId))
            {
                UserRole entity = new UserRole();
                Map(userRole, entity);
                _userRoleRepository.AttachNavigation(entity.User);
                _userRoleRepository.AttachNavigation(entity.Role);
                _userRoleRepository.Add(entity);
                _unitOfWork.SaveChanges();
            }
        }

        public override bool Validate(params object[] parameters)
        {
            int userId = parameters[0].AsInteger();
            int roleId = parameters[1].AsInteger();
            return _userRoleRepository.GetMany(ur =>
                ur.UserId == userId &&
                ur.RoleId == roleId).FirstOrDefault() == null;
        }
    }
}
