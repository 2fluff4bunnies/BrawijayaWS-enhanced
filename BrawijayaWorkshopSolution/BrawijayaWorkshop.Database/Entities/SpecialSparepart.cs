﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SpecialSparepart : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int SparepartId { get; set; }
        public virtual Sparepart Sparepart { get; set; }

        [Required]
        public int ReferenceCategoryId { get; set; }
        public virtual Reference ReferenceCategory { get; set; }        
    }
}