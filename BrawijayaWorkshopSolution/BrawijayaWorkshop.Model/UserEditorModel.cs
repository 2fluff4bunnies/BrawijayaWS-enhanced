using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class UserEditorModel : AppBaseModel
    {
        private IUserRepository _userRepository;
        private IUnitOfWork _unitOfWork;

        public UserEditorModel(IUserRepository userRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public void InsertUser(UserViewModel user)
        {
            User entity = new User();
            Map(user, entity);
            _userRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateUser(UserViewModel user)
        {
            User entity = _userRepository.GetById(user.Id);
            Map(user, entity);
            _userRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        public override bool Validate(params object[] parameters)
        {
            if(parameters.Length > 1)
            {
                string username =  parameters[0].ToString();
                int id = parameters[1].AsInteger();
                return _userRepository.GetMany(u =>
                    string.Compare(u.UserName,username, true) == 0 &&
                    u.Id != id).FirstOrDefault() == null;
            }
            else
            {
                string username = parameters[0].ToString();
                return _userRepository.GetMany(u =>
                    string.Compare(u.UserName, username, true) == 0).FirstOrDefault() == null;
            }
        }
    }
}
