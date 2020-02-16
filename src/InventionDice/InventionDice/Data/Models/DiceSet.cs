using System.Collections.Generic;

namespace InventionDice.Data.Models
{
    public class DiceSet
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<DiceDiceSet> DiceDiceSets { get; set; }
    }
}
