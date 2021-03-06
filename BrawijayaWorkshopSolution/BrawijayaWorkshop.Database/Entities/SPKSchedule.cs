﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BrawijayaWorkshop.Database.Entities
{
    public class SPKSchedule : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; } // only date

        [Required]
        public int SPKId { get; set; }
        public virtual SPK SPK { get; set; }

        [Required]
        public int MechanicId { get; set; }
        public virtual Mechanic Mechanic { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
