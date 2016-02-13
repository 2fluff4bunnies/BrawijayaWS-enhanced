using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
