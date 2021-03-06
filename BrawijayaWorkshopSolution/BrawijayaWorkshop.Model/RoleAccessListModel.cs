﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class RoleAccessListModel : AppBaseModel
    {
        private IRoleAccessRepository _roleAccessRepository;
        private IRoleRepository _roleRepository;
        private IApplicationModulRepository _applicationModulRepository;
        private IUnitOfWork _unitOfWork;

        public RoleAccessListModel(IRoleAccessRepository roleAccessRepository,
            IRoleRepository roleRepository, IApplicationModulRepository applicationModulRepository,
            IUnitOfWork unitOfWork)
            :base()
        {
            _roleAccessRepository = roleAccessRepository;

            _roleRepository = roleRepository;
            _applicationModulRepository = applicationModulRepository;

            _unitOfWork = unitOfWork;
        }

        public List<RoleAccessViewModel> RetrieveAllRoleAccess()
        {
            Role superAdminRole = _roleRepository.GetMany(r => string.Compare(r.Name, DbConstant.ROLE_SUPERADMIN, true) == 0).FirstOrDefault();
            ApplicationModul accessibilityModul = _applicationModulRepository.GetMany(a => string.Compare(a.ModulName, DbConstant.MODUL_ACCESSIBILITY, true) == 0).FirstOrDefault();
            List<RoleAccess> result = _roleAccessRepository.GetMany(ra => ra.RoleId != superAdminRole.Id && ra.ApplicationModulId != accessibilityModul.Id).ToList();
            List<RoleAccessViewModel> mappedResult = new List<RoleAccessViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteRoleAccess(RoleAccessViewModel roleAccess)
        {
            RoleAccess selectedRoleAccess = _roleAccessRepository.GetById(roleAccess.Id);
            _roleAccessRepository.Delete(selectedRoleAccess);
            _unitOfWork.SaveChanges();
        }
    }
}
