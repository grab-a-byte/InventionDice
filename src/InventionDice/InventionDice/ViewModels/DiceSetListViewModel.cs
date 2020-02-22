using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace InventionDice.ViewModels
{
    public class DiceSetListViewModel
    {
        public DiceSetListViewModel(IEnumerable<DiceSetViewModel> sets)
        {
            DiceSetList = new ObservableCollection<DiceSetViewModel>(sets);
        }


        private ObservableCollection<DiceSetViewModel> DiceSetList { get; set; }
    }
}
