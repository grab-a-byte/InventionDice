using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using InventionDice.Data;
using InventionDice.Data.Models;
using InventionDice.Infrastructure;
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

        public Result AddDice(string name, IEnumerable<string> values)
        {
            IEnumerable<DiceValue> diceValues = values.Select(value => new DiceValue() { Value = value}).ToList();
            Dice dice = new Dice() { Name = name, DiceValues = diceValues };
            try
            {
                context.Dice.Add(dice);
                context.SaveChanges();
                return Result.Successfull;
            }
            catch(Exception e)
            {
                return Result.Failure;
            }
        }

        public IEnumerable<DiceViewModel> GetDiceList()
        {
            List<Dice> dice = context.Dice.ToList();
            return mapper.Map<IEnumerable<DiceViewModel>>(dice);
        }
    }
}
