using System;
using System.Collections.Generic;
using System.Linq;
using InventionDice.ViewModels;
using InventionDice.Views.Main;

namespace InventionDice.Services.Navigation
{
    public class ViewViewModelMappings : IViewViewModelMappings
    {
        private readonly IList<ViewViewModelMapping> mappings = new List<ViewViewModelMapping>();

        public ViewViewModelMappings()
        {
            mappings.Add(new ViewViewModelMapping(typeof(MainPage), typeof(MainViewModel)));
        }

        public Type GetViewType<TViewModel>() where TViewModel : ViewModelBase
        {
            Type viewmodelType = typeof(TViewModel);
            return mappings.Single(x => x.ViewModelType == viewmodelType).ViewType;
        }
    }

    internal class ViewViewModelMapping
    {
        public ViewViewModelMapping(Type viewType, Type viewModelType)
        {
            ViewType = viewType;
            ViewModelType = viewModelType;
        }
        public Type ViewType { get; }
        public Type ViewModelType { get; }
    }
}
