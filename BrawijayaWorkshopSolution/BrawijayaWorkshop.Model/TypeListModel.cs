using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class TypeListModel : AppBaseModel
    {
        private ITypeRepository _typeRepository;
        private IUnitOfWork _unitOfWork;

        public TypeListModel(ITypeRepository typeRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _typeRepository = typeRepository;
            _unitOfWork = unitOfWork;
        }

        public List<TypeViewModel> SearchType(string name)
        {
            List<Type> result = _typeRepository.GetMany(c => c.Name.Contains(name) && c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.Name).ToList();
            List<TypeViewModel> mappedResult = new List<TypeViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteType(TypeViewModel type)
        {
            Type selectedType = _typeRepository.GetById<int>(type.Id);
            selectedType.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            _typeRepository.Update(selectedType);
            _unitOfWork.SaveChanges();
        }
    }
}
