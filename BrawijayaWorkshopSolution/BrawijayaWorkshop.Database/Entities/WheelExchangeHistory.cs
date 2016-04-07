using System.ComponentModel.DataAnnotations.Schema;
using System;


namespace BrawijayaWorkshop.Database.Entities
{
    public class WheelExchangeHistory : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int SPKId { get; set; }
        public virtual SPK SPK { get; set; }
        public int OriginalWheelId { get; set; }
        public virtual SpecialSparepartDetail OrignialWheel { get; set; }
        public int ReplaceWheelId { get; set; }
        public virtual SpecialSparepartDetail ReplaceWheel { get; set; }

    }
}
