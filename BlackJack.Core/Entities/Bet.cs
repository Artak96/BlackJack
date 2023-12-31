﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Bet : BaseEntity
    {
        [Key]
        public int BetId { get; set; }
        [ForeignKey("PlayerId")]
        public int PlayerId { get; set; }
        [ForeignKey("GameId")]
        public int GameId { get; set; }
        [ForeignKey("RoundId")]
        public int RoundId { get; set; }
        public decimal Amount { get; set; }

        public Player Player { get; set; }
        public Game Game { get; set; }
        public Round Round { get; set; }
    }
}

