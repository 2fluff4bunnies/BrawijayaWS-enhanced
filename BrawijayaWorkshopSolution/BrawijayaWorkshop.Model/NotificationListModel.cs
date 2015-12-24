using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class NotificationListModel : BaseModel
    {
        private ISPKRepository _spkRepository;
        private IUnitOfWork _unitOfWork;

        public NotificationListModel(ISPKRepository spkRepository, IUnitOfWork unitOfWork)
        {
            _spkRepository = spkRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SPK> SearchSPKPending()
        {
            return _spkRepository.GetMany(c => c.StatusApprovalId == 0).OrderByDescending(c => c.Id).ToList();
        }
    }
}
