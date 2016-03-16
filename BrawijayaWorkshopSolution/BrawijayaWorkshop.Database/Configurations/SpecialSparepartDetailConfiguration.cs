using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    public class SpecialSparepartDetailConfiguration : EntityTypeConfiguration<SpecialSparepartDetail>
    {
        public SpecialSparepartDetailConfiguration()
        {
            HasRequired(wd => wd.SpecialSparepart).WithMany().HasForeignKey(wd => wd.SpecialSparepartId).WillCascadeOnDelete(true);
            HasRequired(wd => wd.SparepartDetail).WithMany().HasForeignKey(wd => wd.SparepartDetailId).WillCascadeOnDelete(true);
            HasRequired(wd => wd.CreateUser).WithMany().HasForeignKey(wd => wd.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(wd => wd.ModifyUser).WithMany().HasForeignKey(wd => wd.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
