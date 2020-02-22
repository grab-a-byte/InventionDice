using AutoMapper;
using InventionDice.Data.Models;
using InventionDice.ViewModels;

namespace InventionDice.Services.Mappings
{
    public class DiceMappingProfile : Profile
    {
        public DiceMappingProfile()
        {
            CreateMap<Dice, DiceViewModel>()
                .ConstructUsing(src => new DiceViewModel(src.Id, src.Name));
        }
    }
}
