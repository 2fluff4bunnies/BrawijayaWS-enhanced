using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    public class SPKConfiguration : EntityTypeConfiguration<SPK>
    {
        public SPKConfiguration()
        {
            HasOptional(spk => spk.SPKParent).WithMany().HasForeignKey(spk => spk.SPKParentId).WillCascadeOnDelete(true);
            HasRequired(spk => spk.CategoryReference).WithMany().HasForeignKey(spk => spk.CategoryReferenceId).WillCascadeOnDelete(false);
            HasRequired(spk => spk.Vehicle).WithMany().HasForeignKey(spk => spk.VehicleId).WillCascadeOnDelete(true);
            HasRequired(spk => spk.CreateUser).WithMany().HasForeignKey(spk => spk.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(spk => spk.ModifyUser).WithMany().HasForeignKey(spk => spk.ModifyUserId).WillCascadeOnDelete(true);
            HasMany(spk => spk.ListSparepart).WithRequired().HasForeignKey(spk => spk.SPKId);
        }
    }
}
