
namespace BrawijayaWorkshop.Constant
{
    public static class DbConstant
    {
        public const string ROLE_ADMIN = "R_ADMIN";
        public const string ROLE_MANAGER = "R_MANAGER";

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
