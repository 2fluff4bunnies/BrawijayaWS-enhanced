using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class RoleListModel : AppBaseModel
    {
        private IRoleRepository _roleRepository;
        private IUnitOfWork _unitOfWork;

        public RoleListModel(IRoleRepository roleRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _roleRepository = roleRepository;
            _unitOfWork = unitOfWork;
        }

        public List<RoleViewModel> SearchRole(string name)
        {
            List<Role> result = _roleRepository.GetMany(r => r.Name.Contains(name) &&
                r.Name != DbConstant.ROLE_SUPERADMIN &&
                r.Name != DbConstant.ROLE_ADMIN &&
                r.Name != DbConstant.ROLE_MANAGER).ToList();
            List<RoleViewModel> mappedResult = new List<RoleViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteRole(RoleViewModel role)
        {
            Role selectedRole = _roleRepository.GetById(role.Id);
            _roleRepository.Delete(selectedRole);
            _unitOfWork.SaveChanges();
        }
    }
}
