using InventionDice.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventionDice.Data.ModelConfigurations
{
    public class DiceSetConfiguration : IEntityTypeConfiguration<DiceSet>
    {
        public void Configure(EntityTypeBuilder<DiceSet> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
