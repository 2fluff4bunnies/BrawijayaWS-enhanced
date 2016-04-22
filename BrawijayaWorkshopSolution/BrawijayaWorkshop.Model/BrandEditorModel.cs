using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class BrandEditorModel : AppBaseModel
    {
        private IBrandRepository _brandRepository;
        private IUnitOfWork _unitOfWork;

        public BrandEditorModel(IBrandRepository brandRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _brandRepository = brandRepository;
            _unitOfWork = unitOfWork;
        }

        public void InsertBrand(BrandViewModel brand)
        {
            brand.Status = (int)DbConstant.DefaultDataStatus.Active;
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    Brand entity = new Brand();
                    Map(brand, entity);
                    _brandRepository.Add(entity);
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

        public void UpdateBrand(BrandViewModel brand)
        {
            Brand entity = _brandRepository.GetById<int>(brand.Id);
            Map(brand, entity);
            _brandRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
