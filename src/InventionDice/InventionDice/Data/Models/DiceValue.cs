namespace InventionDice.Data.Models
{
    public class DiceValue
    {
        public int Id { get; set; }
        public int DiceId { get; set; }
        public Dice Dice { get; set; }
        public string Value { get; set; }
    }
}
