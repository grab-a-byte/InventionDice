using AutoMapper;
using InventionDice.Data.Models;
using InventionDice.ViewModels;

namespace InventionDice.Services.Mappings
{
    class DiceSetMappingProfile : Profile
    {
        public DiceSetMappingProfile()
        {
            CreateMap<DiceSet, DiceSetViewModel>()
                .ConstructUsing(src => new DiceSetViewModel(src.Id, src.Name));
        }
    }
}
