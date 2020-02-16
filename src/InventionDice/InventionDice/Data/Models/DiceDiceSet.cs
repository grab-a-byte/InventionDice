namespace InventionDice.Data.Models
{
    public class DiceDiceSet
    {
        public int Id { get; set; }

        public int DiceId { get; set; }
        public Dice Dice { get; set; }

        public int DiceSetId { get; set; }
        public DiceSet DiceSet { get; set; }
    }
}