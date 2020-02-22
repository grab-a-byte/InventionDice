using System.Collections.Generic;
using InventionDice.Services;
using InventionDice.Services.Navigation;

namespace InventionDice.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;
        private readonly IDiceService diceService;
        private readonly IDiceSetService diceSetService;
        private DiceListViewModel diceList;
        private DiceSetListViewModel diceSetList;

        public MainViewModel(
            INavigationService navigationService,
            IDiceService diceService,
            IDiceSetService diceSetService
            )
        {
            this.navigationService = navigationService;
            this.diceService = diceService;
            this.diceSetService = diceSetService;
        }

        public override void Initialise()
        {
            IsBusy = true;

            IEnumerable<DiceViewModel> dice = diceService.GetDiceList();
            DiceList = new DiceListViewModel(dice, navigationService);

            IEnumerable<DiceSetViewModel> sets = diceSetService.GetDiceSets();
            DiceSetList =  new DiceSetListViewModel(sets);

            IsBusy = false;
        }

        public DiceListViewModel DiceList
        {
            get => diceList;
            set
            {
                diceList = value;
                NotifyPropertyChanged();
            }
        }

        public DiceSetListViewModel DiceSetList
        {
            get => diceSetList;
            set
            {
                diceSetList = value; 
                NotifyPropertyChanged();
            }
        }
    }
}
