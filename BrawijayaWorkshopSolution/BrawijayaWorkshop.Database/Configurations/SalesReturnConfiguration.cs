using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class SalesReturnConfiguration : EntityTypeConfiguration<SalesReturn>
    {
        public SalesReturnConfiguration()
        {
            HasRequired(p => p.Invoice).WithMany().HasForeignKey(p => p.InvoiceId).WillCascadeOnDelete(true);
            HasRequired(p => p.CreateUser).WithMany().HasForeignKey(p => p.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(p => p.ModifyUser).WithMany().HasForeignKey(p => p.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
