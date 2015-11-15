using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SPK
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdateUser { get; set; }

        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public int ReferenceIdCategorySPK { get; set; }
        public int ReferenceIdStatusApprovalSPK{ get; set; }
        public virtual Reference Reference { get; set; }
        public int SPKId { get; set; }
        public virtual SPK SPKParent { get; set; }

    }
}
