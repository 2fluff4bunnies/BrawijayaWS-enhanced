
namespace BrawijayaWorkshop.Constant
{
    public static class RuntimeConstant
    {
        // Email Body
        public const string EMAIL_SUBJECT_ERROR = "[IMPORTANT] Brawijaya Workshop - Error Notification";
        public const string EMAIL_ERROR = "@@error@@";

        public const string EMAIL_SUBJECT_REQUESTAPPROVALSPK = "[IMPORTANT] Brawijaya Workshop - SPK Approval Review";
        public const string EMAIL_APPROVALSPK_BODY = "@@code@@";

        public const string EMAIL_SUBJECT_REQUESTAPPROVALPRINTSPK = "[IMPORTANT] Brawijaya Workshop - SPK Approval Print Request";

        // Log Format
        public static string LOGFORMAT = "{0}: {1}";

        // Miscellaneous
        public const string STRING_COMA = ",";
        public const char CHARACTER_COMA = ',';

        public const string ROLE_SUPERADMIN = "Super Administrator";
        public const string ROLE_ADMIN = "Administrator";
        public const string ROLE_MANAGER = "Manager";

        public static string GetRoleDescription(this string sender)
        {
            switch (sender)
            {
                case DbConstant.ROLE_SUPERADMIN:
                    return ROLE_SUPERADMIN;
                case DbConstant.ROLE_ADMIN:
                    return ROLE_ADMIN;
                case DbConstant.ROLE_MANAGER:
                    return ROLE_MANAGER;
                default:
                    return "Undefined";
            }
        }
    }
}
