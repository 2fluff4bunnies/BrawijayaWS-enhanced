using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class InvoiceConfiguration : EntityTypeConfiguration<Invoice>
    {
        public InvoiceConfiguration()
        {
            HasRequired(p => p.CreateUser).WithMany().HasForeignKey(p => p.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(p => p.ModifyUser).WithMany().HasForeignKey(p => p.ModifyUserId).WillCascadeOnDelete(true);
            HasRequired(p => p.SPK).WithMany().HasForeignKey(p => p.SPKId).WillCascadeOnDelete(true);
            HasRequired(p => p.PaymentMethod).WithMany().HasForeignKey(p => p.PaymentMethod).WillCascadeOnDelete(true);
        }
    }
}
