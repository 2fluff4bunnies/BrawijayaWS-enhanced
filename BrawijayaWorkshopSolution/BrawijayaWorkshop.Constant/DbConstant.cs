
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

        public const string REF_TRANSTBL_PURCHASING = "REF_TRANSTBL_PURCHASING";
        public const string REF_TRANSTBL_SPK = "REF_TRANSTBL_SPK";

        public const string REF_PURCHASE_PAYMENTMETHOD = "REF_PURCHASE_PAYMENTMETHOD";
        public const string REF_PURCHASE_PAYMENTMETHOD_UANGMUKA = "REF_PURCHASE_PAYMENTMETHOD_UANGMUKA";
        public const string REF_PURCHASE_PAYMENTMETHOD_UTANG = "REF_PURCHASE_PAYMENTMETHOD_UTANG";
        public const string REF_PURCHASE_PAYMENTMETHOD_KAS = "REF_PURCHASE_PAYMENTMETHOD_KAS";
        public const string REF_PURCHASE_PAYMENTMETHOD_BANK = "REF_PURCHASE_PAYMENTMETHOD_BANK";

        public const string SETTING_MINTSTOCK = "S_MINSTOCK";
        public const string SETTING_FINGERPRINT_IPADDRESS = "S_FINGERPRINT_IPADDRESS";
        public const string SETTING_FINGERPRINT_PORT = "S_FINGERPRINT_PORT";
        public const string SETTING_SPK_THRESHOLD_MIN = "S_SPK_THRESHOLD_MIN";
        public const string SETTING_SPK_THRESHOLD_MED_MIN = "S_SPK_THRESHOLD_MED_MIN";
        public const string SETTING_SPK_THRESHOLD_MED_MAX = "S_SPK_THRESHOLD_MED_MAX";
        public const string SETTING_SPK_THRESHOLD_MAX = "S_SPK_THRESHOLD_MAX";

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
            Broken = 4,
            NotVerified = 0
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

        public enum SPKCategory
        { 
            Rusak = 1,
            Servis = 2,
            Langsung = 3
        }

        public enum SPKPrintStatus
        { 
            pending = 0,
            ready = 1,
            printed = 2
        }

        public enum SPKCompletionStatus
        { 
            inProgress = 0,
            completed = 1
        }

        public enum PurchasingStatus
        {
            NotVerified = 0,
            Active = 1,
        }

    }
}
