using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SPK : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public int VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public int CategoryStatusApprovalId { get; set; }

        public int CategoryReferenceId { get; set; }

        public virtual Reference CategoryReference { get; set; }

        public int SPKparentId { get; set; }

        public virtual SPK SPKParent { get; set; }

    }
}
