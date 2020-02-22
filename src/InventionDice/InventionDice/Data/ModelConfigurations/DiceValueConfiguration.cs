using InventionDice.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventionDice.Data.ModelConfigurations
{
    public class DiceValueConfiguration : IEntityTypeConfiguration<DiceValue>
    {
        public void Configure(EntityTypeBuilder<DiceValue> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Dice)
                .WithMany(x => x.DiceValues);
        }
    }
}
