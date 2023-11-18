using BlackJack.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DAL.Context
{
    public class BlackJackDbContext : DbContext
    {
        public BlackJackDbContext(DbContextOptions<BlackJackDbContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }
        public DbSet<GameAction> Actions { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GIFT> GIFTs { get; set; }
        public DbSet<Hand> Hands { get; set; }
        public DbSet<Hand_Card> HandCards { get; set; }
        public DbSet<Mineral> Minerals { get; set; }
        public DbSet<Mineral_Transaction> Mineral_Transactions { get; set; }
        public DbSet<Prize> Prizes { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Transfer> Transfers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
