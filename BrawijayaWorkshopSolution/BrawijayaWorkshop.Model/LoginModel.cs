using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class LoginModel : BaseModel
    {
        IUserRepository _userRepository;

        public LoginModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User ValidateLogin(string userName, string password)
        {
            User result = _userRepository.GetMany(u => string.Compare(userName, u.UserName, true) == 0 &&
                string.Compare(password, u.Password, false) == 0).FirstOrDefault();
            return result;
        }
    }
}
