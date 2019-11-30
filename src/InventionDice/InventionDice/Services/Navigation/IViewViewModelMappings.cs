using System;
using InventionDice.ViewModels;

namespace InventionDice.Services.Navigation
{
    public interface IViewViewModelMappings
    {
        Type GetViewType<TViewModel>() where TViewModel : ViewModelBase;
    }
}