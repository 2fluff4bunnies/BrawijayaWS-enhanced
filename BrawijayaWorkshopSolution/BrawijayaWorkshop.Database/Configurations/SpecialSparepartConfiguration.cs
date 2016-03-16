using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    public class SpecialSparepartConfiguration : EntityTypeConfiguration<SpecialSparepart>
    {
        public SpecialSparepartConfiguration()
        {
            HasRequired(specialSparepart => specialSparepart.Sparepart).WithMany().HasForeignKey(specialSparepart => specialSparepart.SparepartId).WillCascadeOnDelete(true);
            HasRequired(specialSparepart => specialSparepart.CreateUser).WithMany().HasForeignKey(specialSparepart => specialSparepart.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(specialSparepart => specialSparepart.ModifyUser).WithMany().HasForeignKey(specialSparepart => specialSparepart.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
