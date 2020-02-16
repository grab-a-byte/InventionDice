using InventionDice.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventionDice.Data.ModelConfigurations
{
    public class DiceDiceSetConfiguration: IEntityTypeConfiguration<DiceDiceSet>
    {
        public void Configure(EntityTypeBuilder<DiceDiceSet> builder)
        {
            builder.HasKey(model => model.Id);

            builder
                .HasOne(dds => dds.Dice)
                .WithMany(d => d.DiceDiceSets)
                .HasForeignKey(x => x.DiceId);
            builder
                .HasOne(dds => dds.DiceSet)
                .WithMany(ds => ds.DiceDiceSets)
                .HasForeignKey(x => x.DiceSetId);
        }
    }
}
