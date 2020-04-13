using System.Collections.Generic;
using InventionDice.Infrastructure;
using InventionDice.ViewModels;

namespace InventionDice.Services
{
    public interface IDiceService
    {
        IEnumerable<DiceViewModel> GetDiceList();
        Result AddDice(string name, IEnumerable<string> values);
    }
}