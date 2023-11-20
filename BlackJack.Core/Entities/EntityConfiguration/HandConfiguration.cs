using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities.EntityConfiguration
{
    public class HandConfiguration : IEntityTypeConfiguration<Hand>
    {
        public void Configure(EntityTypeBuilder<Hand> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
