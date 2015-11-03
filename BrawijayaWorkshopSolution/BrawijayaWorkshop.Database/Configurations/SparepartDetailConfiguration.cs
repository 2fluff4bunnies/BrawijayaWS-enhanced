using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class SparepartDetailConfiguration : EntityTypeConfiguration<SparepartDetail>
    {
        public SparepartDetailConfiguration()
        {
            HasRequired(c => c.Reference).WithMany().HasForeignKey(c => c.ReferenceId).WillCascadeOnDelete(true);
            HasRequired(c => c.PurchasingDetail).WithMany().HasForeignKey(c => c.PurchasingDetailId).WillCascadeOnDelete(true);
        }
    }
}
