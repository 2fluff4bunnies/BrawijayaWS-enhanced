using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class UsedGoodListModel : AppBaseModel
    {
        private IUsedGoodRepository _usedGoodRepository;
        private IUnitOfWork _unitOfWork;

        public UsedGoodListModel(IUsedGoodRepository usedGoodRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _usedGoodRepository = usedGoodRepository;
            _unitOfWork = unitOfWork;
        }

        public List<UsedGoodViewModel> SearchUsedGood(string sparepartName)
        {
            List<UsedGood> result = _usedGoodRepository.GetMany(c => c.Sparepart.Name.Contains(sparepartName)).OrderBy(c => c.Sparepart.Name).ToList();
            List<UsedGoodViewModel> mappedResult = new List<UsedGoodViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteUsedGood(UsedGoodViewModel usedGood)
        {
            UsedGood selectedUsedGood = _usedGoodRepository.GetById<int>(usedGood.Id);
            _usedGoodRepository.Delete(selectedUsedGood);
            _unitOfWork.SaveChanges();
        }
    }
}
