using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class SparepartManualTransactionConfiguration : EntityTypeConfiguration<SparepartManualTransaction>
    {
        public SparepartManualTransactionConfiguration()
        {
            HasRequired(c => c.Sparepart).WithMany().HasForeignKey(c => c.SparepartId).WillCascadeOnDelete(true);
            HasRequired(c => c.CreateUser).WithMany().HasForeignKey(c => c.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(c => c.ModifyUser).WithMany().HasForeignKey(c => c.CreateUserId).WillCascadeOnDelete(true);
        }
    }
}
