using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace InventionDice.AppFiles.AddDice
{
    public class AddDiceHandler : IRequestHandler<AddDiceRequest>
    {
        public Task<Unit> Handle(AddDiceRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
