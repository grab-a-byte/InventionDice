using System.Collections.Generic;
using InventionDice.ViewModels;

namespace InventionDice.Services
{
    public interface IDiceService
    {
        IEnumerable<DiceViewModel> GetDiceList();
    }
}