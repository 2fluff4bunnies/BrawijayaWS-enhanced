using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    public class SPKConfiguration : EntityTypeConfiguration<SPK>
    {
        public SPKConfiguration()
        {
            HasRequired(sp => sp.CategoryReference).WithMany().HasForeignKey(sp => sp.CategoryReferenceId).WillCascadeOnDelete(true);
            HasRequired(sp => sp.StatusApproval).WithMany().HasForeignKey(sp => sp.CategoryStatusApprovalId).WillCascadeOnDelete(true);
            HasRequired(sp => sp.Vehicle).WithMany().HasForeignKey(sp => sp.VehicleId).WillCascadeOnDelete(true);
            HasRequired(sp => sp.CreateUser).WithMany().HasForeignKey(sp => sp.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(sp => sp.ModifyUser).WithMany().HasForeignKey(sp => sp.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
