using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class RoleAccessEditorModel : AppBaseModel
    {
        private IRoleAccessRepository _roleAccessRepository;
        private IRoleRepository _roleRepository;
        private IApplicationModulRepository _applicationModulRepository;
        private IUnitOfWork _unitOfWork;

        public RoleAccessEditorModel(IRoleAccessRepository roleAccessRepository,
            IRoleRepository roleRepository, IApplicationModulRepository applicationModulRepository,
            IUnitOfWork unitOfWork)
            :base()
        {
            _roleAccessRepository = roleAccessRepository;

            _roleRepository = roleRepository;
            _applicationModulRepository = applicationModulRepository;

            _unitOfWork = unitOfWork;
        }

        public List<RoleViewModel> RetrieveAllRoles()
        {
            List<Role> result = _roleRepository.GetAll().ToList();
            List<RoleViewModel> mappedResult = new List<RoleViewModel>();
            return Map(result, mappedResult);
        }

        public List<ApplicationModulViewModel> RetrieveAllApplicationModul()
        {
            List<ApplicationModul> result = _applicationModulRepository.GetAll().ToList();
            List<ApplicationModulViewModel> mappedResult = new List<ApplicationModulViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertRoleAccess(RoleAccessViewModel roleAccess)
        {
            if (!Validate(roleAccess.RoleId, roleAccess.ApplicationModulId)) return;

            RoleAccess entity = new RoleAccess();
            Map(roleAccess, entity);
            _roleAccessRepository.AttachNavigation(entity.ApplicationModul);
            _roleAccessRepository.AttachNavigation(entity.Role);
            _roleAccessRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateRoleAccess(RoleAccessViewModel roleAccess)
        {
            if (!Validate(roleAccess.RoleId, roleAccess.ApplicationModulId, roleAccess.Id)) return;

            RoleAccess entity = _roleAccessRepository.GetById(roleAccess.Id);
            Map(roleAccess, entity);
            _roleAccessRepository.AttachNavigation(entity.ApplicationModul);
            _roleAccessRepository.AttachNavigation(entity.Role);
            _roleAccessRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        public override bool Validate(params object[] parameters)
        {
            if (parameters.Length > 2)
            {
                int roleId = parameters[0].AsInteger();
                int appId = parameters[1].AsInteger();
                int id = parameters[2].AsInteger();
                return _roleAccessRepository.GetMany(ra => ra.RoleId == roleId &&
                    ra.ApplicationModulId == appId &&
                    ra.Id != id).FirstOrDefault() == null;
            }
            else
            {
                int roleId = parameters[0].AsInteger();
                int appId = parameters[1].AsInteger();
                return _roleAccessRepository.GetMany(ra => ra.RoleId == roleId &&
                    ra.ApplicationModulId == appId).FirstOrDefault() == null;
            }
        }
    }
}
