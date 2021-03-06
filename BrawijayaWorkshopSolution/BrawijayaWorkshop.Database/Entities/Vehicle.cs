﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class Vehicle : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string ActiveLicenseNumber { get; set; }

        [Required]
        public int YearOfPurchase { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [Required]
        public int VehicleGroupId { get; set; }
        public virtual VehicleGroup VehicleGroup { get; set; }

        public int Kilometers { get; set; }
        public string Code { get; set; }

        public int TypeId { get; set; }
        public virtual BrawijayaWorkshop.Database.Entities.Type Type { get; set; }

        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
