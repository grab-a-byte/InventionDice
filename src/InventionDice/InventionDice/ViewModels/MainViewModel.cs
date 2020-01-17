using System.Collections.Generic;
using InventionDice.Services;
using InventionDice.Services.Navigation;

namespace InventionDice.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;
        private readonly IDiceService diceService;

        public MainViewModel(INavigationService navigationService, IDiceService diceService)
        {
            this.navigationService = navigationService;
            this.diceService = diceService;
        }

        public override void Initialise()
        {
            IsBusy = true;

            IEnumerable<DiceViewModel> dice = diceService.GetDiceList();

            IsBusy = false;
        }

        public DiceListViewModel DiceList { get; set; }

        public DiceSetListViewModel DiceSetList { get; set; }
    }
}
