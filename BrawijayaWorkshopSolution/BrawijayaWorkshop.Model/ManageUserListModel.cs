using BrawijayaWorkshop.Constant;
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
    public class ManageUserListModel : AppBaseModel
    {
        private IUserRoleRepository _userRoleRepository;
        private IRoleRepository _roleRepository;
        private IUserRepository _userRepository;
        private IUnitOfWork _unitOfWork;

        public ManageUserListModel(IUserRoleRepository userRoleRepository, IRoleRepository roleRepository,
            IUserRepository userRepository, IUnitOfWork unitOfWork)
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

        public List<UserRoleViewModel> RetrieveUsers(int roleId, string name)
        {
            List<UserRole> result = new List<UserRole>();
            Expression<Func<UserRole, bool>> where = null;
            if(roleId > 0)
            {
                where = ur => ur.RoleId == roleId &&
                    (ur.User.FirstName.Contains(name) ||
                     ur.User.LastName.Contains(name) ||
                     ur.User.UserName.Contains(name));
            }
            else
            {
                where = ur => ur.User.FirstName.Contains(name) ||
                              ur.User.LastName.Contains(name) ||
                              ur.User.UserName.Contains(name);
            }
            result = _userRoleRepository.GetMany(where).ToList();
            List<UserRoleViewModel> mappedResult = new List<UserRoleViewModel>();
            return Map(result, mappedResult);
        }

        public void DisableUser(int userId)
        {
            User entity = _userRepository.GetById(userId);
            entity.IsActive = false;
            _userRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
