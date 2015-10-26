using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Runtime
{
    public static class LoginInformation
    {
        public static int UserId { get; private set; }
        public static string UserName { get; private set; }

        public static bool IsLoggedIn { get; private set; }
        public static DateTime LastLogin { get; private set; }

        public static int RoleId { get; private set; }
        public static string RoleName { get; private set; }

        public static List<ModulInfo> AllowedModules { get; private set; }

        static LoginInformation()
        {
            if (AllowedModules == null)
            {
                AllowedModules = new List<ModulInfo>();
            }

            UserName = string.Empty;
            RoleName = string.Empty;
        }

        public static void SetLoggedInInformation(int userId, string userName, int roleId, string roleName)
        {
            IsLoggedIn = true;
            LastLogin = DateTime.Now;

            UserId = userId;
            UserName = UserName;
            RoleId = roleId;
            RoleName = roleName;
        }

        public static void AddModulInfo(ModulInfo info)
        {
            AllowedModules.Add(info);
        }

        public static void SetLoggedOut()
        {
            IsLoggedIn = false;
            LastLogin = DateTime.Now;

            UserId = 0;
            UserName = string.Empty;
            RoleId = 0;
            RoleName = string.Empty;

            AllowedModules.Clear();
            AllowedModules = new List<ModulInfo>();
        }
    }

    public class ModulInfo
    {
        public int ModulId { get; set; }
        public string ModulName { get; set; }
        public int AccessCode { get; set; }
    }
}
