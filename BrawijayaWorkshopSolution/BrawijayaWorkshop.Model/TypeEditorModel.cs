using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class TypeEditorModel : AppBaseModel
    {
        private ITypeRepository _typeRepository;
        private IUnitOfWork _unitOfWork;

        public TypeEditorModel(ITypeRepository typeRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _typeRepository = typeRepository;
            _unitOfWork = unitOfWork;
        }

        public void InsertType(TypeViewModel type)
        {
            type.Status = (int)DbConstant.DefaultDataStatus.Active;
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    Type entity = new Type();
                    Map(type, entity);
                    _typeRepository.Add(entity);
                    _unitOfWork.SaveChanges();

                    trans.Commit();
                }
                catch (System.Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
            }
        }

        public void UpdateType(TypeViewModel type)
        {
            Type entity = _typeRepository.GetById<int>(type.Id);
            Map(type, entity);
            _typeRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
