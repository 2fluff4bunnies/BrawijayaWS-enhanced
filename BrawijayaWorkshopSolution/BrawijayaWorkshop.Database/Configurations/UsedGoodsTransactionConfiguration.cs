using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class UsedGoodsTransactionConfiguration : EntityTypeConfiguration<UsedGoodsTransaction>
    {
        public UsedGoodsTransactionConfiguration()
        {
            HasRequired(p => p.CreateUser).WithMany().HasForeignKey(p => p.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(p => p.ModifyUser).WithMany().HasForeignKey(p => p.ModifyUserId).WillCascadeOnDelete(true);
            HasRequired(p => p.UsedGoods).WithMany().HasForeignKey(p => p.UsedGoodsId).WillCascadeOnDelete(true);
            HasRequired(p => p.TypeReference).WithMany().HasForeignKey(p => p.TypeReferenceId).WillCascadeOnDelete(true);
        }
    }
}
