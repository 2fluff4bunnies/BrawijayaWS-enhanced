using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class UsedGoodEditorModel : AppBaseModel
    {
        private IUsedGoodRepository _usedGoodRepository;
        private ISparepartRepository _sparepartRepository;
        private IUnitOfWork _unitOfWork;

        public UsedGoodEditorModel(IUsedGoodRepository usedGoodRepository, ISparepartRepository sparepartRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _usedGoodRepository = usedGoodRepository;
            _sparepartRepository = sparepartRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SparepartViewModel> RetrieveSparepart()
        {
            List<Sparepart> result = _sparepartRepository.GetAll().ToList();
            List<SparepartViewModel> mappedResult = new List<SparepartViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertUsedGood(UsedGoodViewModel usedGood)
        {
            usedGood.Status = (int)DbConstant.DefaultDataStatus.Active;
            UsedGood entity = new UsedGood();
            Map(usedGood, entity);
            _usedGoodRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateUsedGood(UsedGoodViewModel usedGood)
        {
            UsedGood entity = _usedGoodRepository.GetById<int>(usedGood.Id);
            Map(usedGood, entity);
            _usedGoodRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
