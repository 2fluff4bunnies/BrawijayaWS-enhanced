using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class InvoiceDetailConfiguration : EntityTypeConfiguration<InvoiceDetail>
    {
        public InvoiceDetailConfiguration()
        {
            HasRequired(p => p.CreateUser).WithMany().HasForeignKey(p => p.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(p => p.ModifyUser).WithMany().HasForeignKey(p => p.ModifyUserId).WillCascadeOnDelete(true);
            HasRequired(p => p.Invoice).WithMany().HasForeignKey(p => p.InvoiceId).WillCascadeOnDelete(true);
            HasRequired(p => p.SPKDetailSparepartDetail).WithMany().HasForeignKey(p => p.SPKDetailSparepartDetailId).WillCascadeOnDelete(true);
        }
    }
}
