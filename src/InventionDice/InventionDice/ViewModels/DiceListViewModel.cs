using System.Collections.Generic;
using System.Collections.ObjectModel;
using InventionDice.Services.Navigation;
using Xamarin.Forms;

namespace InventionDice.ViewModels
{
    public class DiceListViewModel
    {
        private readonly INavigationService navigationService;

        public DiceListViewModel(IEnumerable<DiceViewModel> dice, INavigationService navigationService)
        {
            this.navigationService = navigationService;
            DiceList = new ObservableCollection<DiceViewModel>(dice);
            NavigateToAddDicePage = new Command(() => NavigateToAddDice());
        }
        public ObservableCollection<DiceViewModel> DiceList { get; }

        public Command NavigateToAddDicePage { get; set; }

        private void NavigateToAddDice()
        {
            //navigationService.NavigateTo<>();
        }
    }
}
