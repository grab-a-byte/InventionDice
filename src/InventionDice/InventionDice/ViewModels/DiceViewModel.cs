namespace InventionDice.ViewModels
{
    public class DiceViewModel
    {
        public DiceViewModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }
    }
}
