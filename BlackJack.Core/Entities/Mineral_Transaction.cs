﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Mineral_Transaction : BaseEntity
    { 

        [Key]
        public int MineralTransactionId { get; set;}
        [ForeignKey("PlayerId")]
        public int PlayerId { get; set; }
        [ForeignKey("GameId")]
        public int GameId { get; set; }
        public int Initial_Player_Order { get; set; }
        public string? Score { get; set; }

        public Player Player { get; set; }
        public Game Game { get; set; }
    }
}
