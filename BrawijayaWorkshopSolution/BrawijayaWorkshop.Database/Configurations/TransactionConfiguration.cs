using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class TransactionConfiguration : EntityTypeConfiguration<Transaction>
    {
        public TransactionConfiguration()
        {
            HasRequired(t => t.ReferenceTable).WithMany().HasForeignKey(t => t.ReferenceTableId).WillCascadeOnDelete(true);
            HasRequired(t => t.CreateUser).WithMany().HasForeignKey(t => t.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(t => t.ModifyUser).WithMany().HasForeignKey(t => t.ModifyUserId).WillCascadeOnDelete(true);
            HasOptional(t => t.PaymentMethod).WithMany().HasForeignKey(t => t.PaymentMethodId).WillCascadeOnDelete(true);
        }
    }
}
