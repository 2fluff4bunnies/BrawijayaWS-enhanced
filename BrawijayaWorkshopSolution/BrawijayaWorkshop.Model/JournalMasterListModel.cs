using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class JournalMasterListModel : BaseModel
    {
        private IJournalMasterRepository _journalMasterRepository;
        private IUnitOfWork _unitOfWork;

        public JournalMasterListModel(IJournalMasterRepository journalMasterRepository, IUnitOfWork unitOfWOrk)
        {
            _journalMasterRepository = journalMasterRepository;
            _unitOfWork = unitOfWOrk;
        }

        public List<JournalMaster> GetAllJournal(int parentId, string name)
        {
            if (parentId > 0)
            {
                return _journalMasterRepository.GetMany(jm => jm.ParentId == parentId && jm.Name.Contains(name)).OrderBy(jm => jm.Name).ToList();
            }

            return _journalMasterRepository.GetMany(jm => jm.Name.Contains(name)).OrderBy(jm => jm.Name).ToList();
        }

        public List<JournalMaster> GetAllParentJournal()
        {
            return _journalMasterRepository.GetMany(jm => jm.ParentId == 0).OrderBy(jm => jm.Name).ToList();
        }

        public void DeleteJournal(JournalMaster journal)
        {
            _journalMasterRepository.Delete(journal);
            _unitOfWork.SaveChanges();
        }
    }
}
