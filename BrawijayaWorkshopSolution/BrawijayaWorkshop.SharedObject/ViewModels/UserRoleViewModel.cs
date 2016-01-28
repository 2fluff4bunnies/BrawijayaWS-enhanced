
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class UserRoleViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserViewModel User { get; set; }
        public int RoleId { get; set; }
        public RoleViewModel Role { get; set; }
    }
}
