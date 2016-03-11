using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class UserRoleListModel : AppBaseModel
    {
        private IRoleRepository _roleRepository;
        private IUserRoleRepository _userRoleRepository;
        private IUnitOfWork _unitOfWork;

        public UserRoleListModel(IRoleRepository roleRepository, IUserRoleRepository userRoleRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _roleRepository = roleRepository;
            _userRoleRepository = userRoleRepository;
            _unitOfWork = unitOfWork;
        }

        public List<RoleViewModel> RetrieveAllRole()
        {
            List<Role> result = _roleRepository.GetAll().ToList();
            List<RoleViewModel> mappedResult = new List<RoleViewModel>();
            return Map(result, mappedResult);
        }

        public List<UserRoleViewModel> RetrieveUserRoleByRoleId(int senderUserId, int roleId)
        {
            List<UserRole> result = null;
            if (roleId > 0)
            {
                result = _userRoleRepository.GetMany(ur => ur.RoleId == roleId && ur.UserId != senderUserId).ToList();
            }
            else
            {
                result = _userRoleRepository.GetMany(ur => ur.UserId != senderUserId).ToList();
            }
            List<UserRoleViewModel> mappedResult = new List<UserRoleViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteUserRole(UserRoleViewModel userRole)
        {
            UserRole entity = _userRoleRepository.GetById(userRole.Id);
            _userRoleRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
