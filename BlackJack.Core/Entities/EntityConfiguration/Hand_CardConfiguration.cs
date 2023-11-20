using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace BlackJack.Core.Entities.EntityConfiguration
{
    public class Hand_CardConfiguration : IEntityTypeConfiguration<Hand_Card>
    {
        public void Configure(EntityTypeBuilder<Hand_Card> builder)
        {
            builder.HasNoKey();
        }
    }
}

