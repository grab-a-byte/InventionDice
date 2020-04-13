using InventionDice.Infrastructure;
using MediatR;
using System.Collections.Generic;

namespace InventionDice.AppFiles.AddDice
{
    public class AddDiceRequest : IRequest<Result>
    {
        public AddDiceRequest(string diceName, IEnumerable<string> diceValues)
        {
            DiceName = diceName;
            DiceValues = diceValues;
        }
        public string DiceName { get; }
        public IEnumerable<string> DiceValues { get; set; }
    }
}
