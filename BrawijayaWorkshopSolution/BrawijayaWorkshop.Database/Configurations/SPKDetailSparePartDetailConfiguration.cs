using BrawijayaWorkshop.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Database.Configurations
{
    public class SPKDetailSparepartDetailConfiguration : EntityTypeConfiguration<SPKDetailSparepartDetail>
    {
        public SPKDetailSparepartDetailConfiguration()
        {
            HasRequired(sp => sp.PurchasingDetail).WithMany().HasForeignKey(sp => sp.PurchasingDetailId).WillCascadeOnDelete(true);
            HasRequired(sp => sp.SparepartManualTransaction).WithMany().HasForeignKey(sp => sp.SparepartManualTransactionId).WillCascadeOnDelete(true);
            HasRequired(sp => sp.SPKDetailSparepart).WithMany().HasForeignKey(sp => sp.SPKDetailSparepartId).WillCascadeOnDelete(true);
            HasRequired(sp => sp.CreateUser).WithMany().HasForeignKey(sp => sp.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(sp => sp.ModifyUser).WithMany().HasForeignKey(sp => sp.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
