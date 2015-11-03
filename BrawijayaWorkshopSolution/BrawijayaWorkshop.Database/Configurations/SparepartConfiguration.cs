using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class SparepartConfiguration : EntityTypeConfiguration<Sparepart>
    {
        public SparepartConfiguration()
        {
            HasRequired(c => c.Reference).WithMany().HasForeignKey(c => c.ReferenceId).WillCascadeOnDelete(true);            
        }
    }
}
