using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Model
{
    public class JournalMasterEditorModel : BaseModel
    {
        private IJournalMasterRepository _journalMasterRepository;
        private IUnitOfWork _unitOfWork;

        public JournalMasterEditorModel(IJournalMasterRepository journalMasterRepository, IUnitOfWork unitOfWork)
        {
            _journalMasterRepository = journalMasterRepository;
            _unitOfWork = unitOfWork;
        }

        public List<JournalMaster> GetAllParentJournal()
        {
            return _journalMasterRepository.GetMany(jm => jm.ParentId == null).OrderBy(jm => jm.Name).ToList();
        }

        public void InsertJournal(JournalMaster journal)
        {
            _journalMasterRepository.Add(journal);
            _unitOfWork.SaveChanges();
        }

        public void UpdateJournal(JournalMaster journal)
        {
            _journalMasterRepository.Update(journal);
            _unitOfWork.SaveChanges();
        }
    }
}
