using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace InventionDice.ViewModels
{
    public class DiceListViewModel
    {
        public DiceListViewModel(IEnumerable<DiceViewModel> dice)
        {
            DiceList = new ObservableCollection<DiceViewModel>(dice);
        }
        public ObservableCollection<DiceViewModel> DiceList { get; }
    }
}
