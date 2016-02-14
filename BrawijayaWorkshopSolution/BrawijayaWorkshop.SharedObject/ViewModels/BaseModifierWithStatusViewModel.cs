using System;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class BaseModifierWithStatusViewModel : BaseStatusEntityViewModel
    {
        public DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public UserViewModel CreateUser { get; set; }

        public DateTime ModifyDate { get; set; }
        public int ModifyUserId { get; set; }
        public UserViewModel ModifyUser { get; set; }
    }
}
