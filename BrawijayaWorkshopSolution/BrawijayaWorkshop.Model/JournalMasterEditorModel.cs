using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class JournalMasterEditorModel : AppBaseModel
    {
        private IJournalMasterRepository _journalMasterRepository;
        private IUnitOfWork _unitOfWork;

        public JournalMasterEditorModel(IJournalMasterRepository journalMasterRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _journalMasterRepository = journalMasterRepository;
            _unitOfWork = unitOfWork;
        }

        public List<JournalMasterViewModel> GetAllParentJournal()
        {
            List<JournalMaster> result = _journalMasterRepository.GetAll().OrderBy(jm => jm.Name).ToList();
            List<JournalMasterViewModel> mappedResult = new List<JournalMasterViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertJournal(JournalMasterViewModel journal)
        {
            JournalMaster entity = new JournalMaster();
            Map(journal, entity);
            _journalMasterRepository.AttachNavigation<JournalMaster>(entity.Parent);
            _journalMasterRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateJournal(JournalMasterViewModel journal)
        {
            JournalMaster entity = _journalMasterRepository.GetById(journal.Id);
            Map(journal, entity);
            _journalMasterRepository.AttachNavigation<JournalMaster>(entity.Parent);
            _journalMasterRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
