using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class SparepartConfiguration : EntityTypeConfiguration<Sparepart>
    {
        public SparepartConfiguration()
        {
            HasRequired(sp => sp.CategoryReference).WithMany().HasForeignKey(sp => sp.CategoryReferenceId).WillCascadeOnDelete(true);
            HasRequired(sp => sp.UnitReference).WithMany().HasForeignKey(sp => sp.UnitReferenceId).WillCascadeOnDelete(true);
            HasRequired(sp => sp.CreateUser).WithMany().HasForeignKey(sp => sp.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(sp => sp.ModifyUser).WithMany().HasForeignKey(sp => sp.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
