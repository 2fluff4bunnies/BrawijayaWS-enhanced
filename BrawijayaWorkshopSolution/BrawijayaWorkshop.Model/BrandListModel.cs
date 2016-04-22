using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class BrandListModel : AppBaseModel
    {
        private IBrandRepository _brandRepository;
        private IUnitOfWork _unitOfWork;

        public BrandListModel(IBrandRepository brandRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _brandRepository = brandRepository;
            _unitOfWork = unitOfWork;
        }

        public List<BrandViewModel> SearchBrand(string name)
        {
            List<Brand> result = _brandRepository.GetMany(c => c.Name.Contains(name) && c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.Name).ToList();
            List<BrandViewModel> mappedResult = new List<BrandViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteBrand(BrandViewModel brand)
        {
            Brand selectedBrand = _brandRepository.GetById<int>(brand.Id);
            selectedBrand.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            _brandRepository.Update(selectedBrand);
            _unitOfWork.SaveChanges();
        }
    }
}
