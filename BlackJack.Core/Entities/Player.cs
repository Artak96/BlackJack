using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string Name  { get; set; } 
        public string UserName  { get; set; }
        public string Email  { get; set; }
        public decimal Balance  { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsMerchant { get; set; }   
        public bool IsOwner { get; set; }
    }
}
