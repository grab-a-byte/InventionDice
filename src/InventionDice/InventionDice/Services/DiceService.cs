using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using InventionDice.Data;
using InventionDice.Data.Models;
using InventionDice.ViewModels;

namespace InventionDice.Services
{
    public class DiceService : IDiceService
    {
        private readonly AppDatabaseContext context;
        private readonly IMapper mapper;

        public DiceService(AppDatabaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IEnumerable<DiceViewModel> GetDiceList()
        {
            List<Dice> dice = context.Dice.ToList();
            return mapper.Map<IEnumerable<DiceViewModel>>(dice);
        }
    }
}
