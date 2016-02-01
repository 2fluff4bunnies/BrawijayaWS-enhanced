using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class JournalMasterListModel : AppBaseModel
    {
        private IJournalMasterRepository _journalMasterRepository;
        private IUnitOfWork _unitOfWork;

        public JournalMasterListModel(IJournalMasterRepository journalMasterRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _journalMasterRepository = journalMasterRepository;
            _unitOfWork = unitOfWork;
        }

        public List<JournalMasterViewModel> GetAllJournal(int parentId, string name)
        {
            List<JournalMaster> result = null;
            if (parentId > 0)
            {
                result = _journalMasterRepository.GetMany(jm => jm.ParentId == parentId && jm.Name.Contains(name)).OrderBy(jm => jm.Name).ToList();
            }

            result = _journalMasterRepository.GetMany(jm => jm.Name.Contains(name)).OrderBy(jm => jm.Name).ToList();

            List<JournalMasterViewModel> mappedResult = new List<JournalMasterViewModel>();
            return Map(result, mappedResult);
        }

        public List<JournalMasterViewModel> GetAllParentJournal()
        {
            List<JournalMaster> result = _journalMasterRepository.GetMany(jm => jm.ParentId == null).OrderBy(jm => jm.Name).ToList();
            List<JournalMasterViewModel> mappedResult = new List<JournalMasterViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteJournal(JournalMasterViewModel journal)
        {
            JournalMaster entity = _journalMasterRepository.GetById(journal.Id);
            _journalMasterRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
