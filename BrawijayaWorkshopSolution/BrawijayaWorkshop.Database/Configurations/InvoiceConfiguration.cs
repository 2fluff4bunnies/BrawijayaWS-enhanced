using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class InvoiceConfiguration : EntityTypeConfiguration<Invoice>
    {
        public InvoiceConfiguration()
        {
            HasRequired(i => i.CreateUser).WithMany().HasForeignKey(i => i.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(i => i.ModifyUser).WithMany().HasForeignKey(i => i.ModifyUserId).WillCascadeOnDelete(true);
            HasRequired(i => i.SPK).WithMany().HasForeignKey(i => i.SPKId).WillCascadeOnDelete(true);
            HasRequired(i => i.PaymentMethod).WithMany().HasForeignKey(i => i.PaymentMethodId).WillCascadeOnDelete(true);

            HasMany(i =>i.InvoiceDetails).WithRequired().HasForeignKey(i => i.InvoiceId);
        }
    }
}
