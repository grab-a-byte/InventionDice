using System.Threading;
using System.Threading.Tasks;
using InventionDice.Infrastructure;
using InventionDice.Services;
using MediatR;

namespace InventionDice.AppFiles.AddDice
{
    public class AddDiceHandler : IRequestHandler<AddDiceRequest, Result>
    {
        private readonly IDiceService diceService;

        public AddDiceHandler(IDiceService diceService)
        {
            this.diceService = diceService;
        }

        public async Task<Result> Handle(AddDiceRequest request, CancellationToken cancellationToken)
        {
            return diceService.AddDice(request.DiceName, request.DiceValues);
        }
    }
}
