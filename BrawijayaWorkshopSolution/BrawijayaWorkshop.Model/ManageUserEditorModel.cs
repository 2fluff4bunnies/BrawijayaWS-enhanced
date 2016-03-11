using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class ManageUserEditorModel : AppBaseModel
    {
        private IUserRoleRepository _userRoleRepository;
        private IUserRepository _userRepository;
        private IRoleRepository _roleRepository;
        private IUnitOfWork _unitOfWork;

        public ManageUserEditorModel(IUserRoleRepository userRoleRepository, IUserRepository userRepository,
            IRoleRepository roleRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _userRoleRepository = userRoleRepository;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _unitOfWork = unitOfWork;
        }

        public List<RoleViewModel> RetrieveRoles()
        {
            List<Role> result = _roleRepository.GetMany(r => r.Name != DbConstant.ROLE_SUPERADMIN).ToList();
            List<RoleViewModel> mappedResult = new List<RoleViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertUserRole(UserRoleViewModel userRole)
        {
            User userEntity = new User();
            Map(userRole.User, userEntity);
            userEntity = _userRepository.Add(userEntity);

            UserRole userRoleEntity = new UserRole();
            userRoleEntity.UserId = userEntity.Id;
            userRoleEntity.RoleId = userRole.RoleId;
            _userRoleRepository.Add(userRoleEntity);

            _unitOfWork.SaveChanges();
        }

        public void UpdateUserRole(UserRoleViewModel userRole)
        {
            UserRole entity = _userRoleRepository.GetById(userRole.Id);
            entity.RoleId = userRole.Id;
            _userRoleRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }

        public override bool Validate(params object[] parameters)
        {
            if (parameters.Length > 1)
            {
                string username = parameters[0].ToString();
                int userId = parameters[1].AsInteger();
                int roleId = parameters[2].AsInteger();
                return _userRepository.GetMany(u =>
                    string.Compare(u.UserName, username, true) == 0 &&
                    u.Id != userId).FirstOrDefault() == null &&
                    _userRoleRepository.GetMany(ur =>
                        ur.UserId == userId &&
                        ur.RoleId == roleId).FirstOrDefault() == null;
            }
            else
            {
                string username = parameters[0].ToString();
                return _userRepository.GetMany(u =>
                    string.Compare(u.UserName, username, true) == 0).FirstOrDefault() == null;
            }
        }
    }
}
