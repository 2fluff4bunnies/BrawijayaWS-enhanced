using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class SalesReturnDetailConfiguration : EntityTypeConfiguration<SalesReturnDetail>
    {
        public SalesReturnDetailConfiguration()
        {
            HasRequired(p => p.SalesReturn).WithMany().HasForeignKey(p => p.SalesReturnId).WillCascadeOnDelete(true);
            HasRequired(p => p.InvoiceDetail).WithMany().HasForeignKey(p => p.InvoiceDetailId).WillCascadeOnDelete(true);
            HasRequired(p => p.CreateUser).WithMany().HasForeignKey(p => p.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(p => p.ModifyUser).WithMany().HasForeignKey(p => p.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
