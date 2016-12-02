﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SparepartStockCard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public virtual User CreateUser { get; set; }

        public int SparepartId { get; set; }
        public virtual Sparepart Sparepart { get; set; }

        public int ReferenceTableId { get; set; }
        public virtual Reference ReferenceTable { get; set; }

        public int PrimaryKeyValue { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public double QtyFirst { get; set; }
        public double QtyIn { get; set; }
        public double QtyOut { get; set; }
        public double QtyLast { get; set; }
    }
}
