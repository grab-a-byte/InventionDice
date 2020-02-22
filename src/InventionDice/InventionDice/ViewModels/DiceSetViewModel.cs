namespace InventionDice.ViewModels
{
    public class DiceSetViewModel : ViewModelBase
    {
        public DiceSetViewModel(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; }

        public string Name { get; }
    }
}
