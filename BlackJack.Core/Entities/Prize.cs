﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Prize : BaseEntity
    {
        [Key]
        public int PrizeId { get; set; }
        [ForeignKey("RoundId")]
        public int RounId { get; set; }
        [ForeignKey("PlayerId")]
        public int PlayerId { get; set; }
        public decimal Amount { get; set; }
        public string? Type { get; set; }

        public Round Round { get; set; }
        public Player Player { get; set; }
    }
}
