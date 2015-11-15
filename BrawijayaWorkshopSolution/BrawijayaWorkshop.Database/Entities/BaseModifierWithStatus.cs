using System;

namespace BrawijayaWorkshop.Database.Entities
{
    public class BaseModifierWithStatus : BaseStatusEntity
    {
        public DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public virtual User CreateUser { get; set; }

        public DateTime ModifyDate { get; set; }
        public int ModifyUserId { get; set; }
        public virtual User ModifyUser { get; set; }
    }
}
