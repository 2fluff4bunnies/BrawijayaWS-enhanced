
namespace BrawijayaWorkshop.Constant
{
    public static class DbConstant
    {
        public const string ROLE_SUPERADMIN = "R_SUPERADMIN";
        public const string ROLE_ADMIN = "R_ADMIN";
        public const string ROLE_MANAGER = "R_MANAGER";

        public const string MODUL_USERCONTROL = "M_USERCONTROL";
        public const string MODUL_DBCONFIG = "M_DBCONFIG";

        public const string MODUL_CUSTOMER = "M_CUSTOMER";
        public const string MODUL_VEHICLE = "M_VEHICLE";
        public const string MODUL_SPAREPART = "M_SPAREPART";
        public const string MODUL_SUPPLIER = "M_SUPPLIER";
        public const string MODUL_PURCHASING = "M_PURCHASING";

        public enum AccessTypeEnum
        {
            Read = 1,
            Create = 2,
            Update = 4,
            Delete = 8,

            All = Read | Create | Update | Delete
        }
    }
}
