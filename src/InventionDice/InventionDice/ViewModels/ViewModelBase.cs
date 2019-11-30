namespace InventionDice.ViewModels
{
    public class ViewModelBase
    {
        public virtual void Initialise()
        {
        }

        public bool IsBusy { get; set; }
    }
}
