using InventionDice.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventionDice.Data.ModelConfigurations
{
    public class DiceConfiguration : IEntityTypeConfiguration<Dice>
    {
        public void Configure(EntityTypeBuilder<Dice> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.DiceValues)
                .WithOne(x => x.Dice);
        }
    }
}
