using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class NotificationListModel : AppBaseModel
    {
        private ISPKRepository _spkRepository;
        private IUnitOfWork _unitOfWork;

        public NotificationListModel(ISPKRepository spkRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _spkRepository = spkRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SPKViewModel> SearchSPKPending()
        {
            List<SPK> result = _spkRepository.GetMany(spk => 
                (spk.StatusApprovalId == (int)DbConstant.ApprovalStatus.Pending || spk.StatusPrintId == (int) DbConstant.SPKPrintStatus.Pending) &&
                spk.Status == (int)DbConstant.DefaultDataStatus.Active
                ).OrderByDescending(c => c.Id).ToList();
            List<SPKViewModel> mappedResult = new List<SPKViewModel>();
            return Map(result, mappedResult);
        }
    }
}
