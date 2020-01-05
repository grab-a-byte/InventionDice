using InventionDice.Services.Navigation;

namespace InventionDice.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public override void Initialise()
        {
            IsBusy = true;

            IsBusy = false;
        }

        public DiceListViewModel DiceList { get; set; }

        public DiceSetListViewModel DiceSetList { get; set; }
    }
}
