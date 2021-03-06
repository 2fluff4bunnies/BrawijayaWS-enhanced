﻿using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class RoleEditorModel : AppBaseModel
    {
        private IRoleRepository _roleRepository;
        private IUnitOfWork _unitOfWork;

        public RoleEditorModel(IRoleRepository roleRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _roleRepository = roleRepository;
            _unitOfWork = unitOfWork;
        }

        public void InsertRole(RoleViewModel role)
        {
            if (!Validate(role.Name)) return;

            Role entity = new Role();
            Map(role, entity);
            _roleRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateRole(RoleViewModel role)
        {
            if (!Validate(role.Name, role.Id)) return;

            Role entity = _roleRepository.GetById(role.Id);
            Map(role, entity);
            _roleRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        public override bool Validate(params object[] parameters)
        {
            if (parameters.Length > 1)
            {
                string name = parameters[0].ToString();
                int id = parameters[1].AsInteger();
                return _roleRepository.GetMany(r =>
                    string.Compare(r.Name, name, true) == 0 &&
                    r.Id != id).FirstOrDefault() == null;
            }
            else
            {
                string name = parameters[0].ToString();
                return _roleRepository.GetMany(r =>
                string.Compare(r.Name, name, true) == 0).FirstOrDefault() == null;
            }
        }
    }
}
