
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
        public const string MODUL_JOURNAL = "M_JOURNAL";
        public const string MODUL_VEHICLE = "M_VEHICLE";
        public const string MODUL_SPAREPART = "M_SPAREPART";
        public const string MODUL_SPAREPART_DETAIL = "M_SPAREPART_DETAIL";
        public const string MODUL_SUPPLIER = "M_SUPPLIER";
        public const string MODUL_PURCHASING = "M_PURCHASING";
        public const string MODUL_SERVICE = "M_SERVICE";
        public const string MODUL_APPROVAL = "M_APPROVAL";
        public const string MODUL_MECHANIC = "M_MECHANIC";
        public const string MODUL_VEHICLE_DETAIL = "M_VEHICLE_DETAIL";
        public const string MODUL_SPK = "M_SPK";
        public const string MODUL_SPK_DETAIL_MECHANIC = "M_SPK_DETAIL_MECHANIC";
        public const string MODUL_SPK_DETAIL_SPAREPART = "M_SPK_DETAIL_SPAREPART";
        public const string MODUL_SPK_DETAIL_SPAREPART_DETAIL = "M_SPK_DETAIL_SPAREPART_DETAIL";

        public const string REF_SPAREPARTCATEGORY = "REF_SPAREPARTCATEGORY";
        public const string REF_SPAREPARTUNIT = "REF_SPAREPARTUNIT";

        public const string REF_SPKCATEGORY = "REF_SPKCATEGORY";

        public const string SETTING_MINTSTOCK = "S_MINSTOCK";
        public const string SETTING_FINGERPRINT_IPADDRESS = "S_FINGERPRINT_IPADDRESS";
        public const string SETTING_FINGERPRINT_PORT = "S_FINGERPRINT_PORT";

        public enum AccessTypeEnum
        {
            Read = 1,
            Create = 2,
            Update = 4,
            Delete = 8,

            All = Read | Create | Update | Delete
        }

        public enum DefaultDataStatus
        {
            Active = 1,
            Deleted = -1
        }

        public enum SparepartDetailDataStatus
        {
            Active = 1,
            Deleted = -1,
            OutPurchase = 2,
            OutService = 3,
            Broken = 4
        }

        public enum ApprovalStatus
        {
            Pending = 0,
            Approved = 1,
            Rejected = -1,
            Endorsed = 2
        }

        public enum LicenseNumberStatus
        {
            Active = 1,
            Expired = -1
        }

    }
}
