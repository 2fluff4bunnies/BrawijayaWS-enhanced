using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class JournalMasterConfiguration : EntityTypeConfiguration<JournalMaster>
    {
        public JournalMasterConfiguration()
        {
            HasRequired(jm => jm.Parent).WithMany().HasForeignKey(jm => jm.ParentId).WillCascadeOnDelete(true);
        }
    }
}
