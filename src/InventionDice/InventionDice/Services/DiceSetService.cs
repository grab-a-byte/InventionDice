using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using InventionDice.Data;
using InventionDice.ViewModels;

namespace InventionDice.Services
{
    public class DiceSetService : IDiceSetService
    {
        private readonly AppDatabaseContext context;
        private readonly IMapper mapper;

        public DiceSetService(AppDatabaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IEnumerable<DiceSetViewModel> GetDiceSets()
        {
            var diceSets = context.DiceSets.ToList();
            return mapper.Map<IEnumerable<DiceSetViewModel>>(diceSets);
        }
    }

    public interface IDiceSetService
    {
        IEnumerable<DiceSetViewModel> GetDiceSets();
    }
}
