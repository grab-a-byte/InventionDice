using System;
using InventionDice.ViewModels;
using Xamarin.Forms;

namespace InventionDice.Services.Navigation
{
    public class NavigationService : INavigationService 
    {
        private readonly IViewViewModelMappings viewViewModelMappings;
        private readonly ViewModelFactory viewModelFactory;
        private readonly IPageService pageService;

        public NavigationService(IViewViewModelMappings viewViewModelMappings, ViewModelFactory viewModelFactory, IPageService pageService)
        {
            this.viewViewModelMappings = viewViewModelMappings;
            this.viewModelFactory = viewModelFactory;
            this.pageService = pageService;
        }
        public void NavigateTo<TViewModel>() where TViewModel : ViewModelBase
        {
            var viewType = viewViewModelMappings.GetViewType<TViewModel>();
            var view = Activator.CreateInstance(viewType);
            var page = view as Page;
            page.BindingContext = viewModelFactory.GetViewModel<TViewModel>();
            pageService.PushAsync(page);
        }

        public void NavigateTo<TViewModel>(TViewModel viewModel) where TViewModel : ViewModelBase
        {
            var viewType = viewViewModelMappings.GetViewType<TViewModel>();
            var view = Activator.CreateInstance(viewType);
            var page = view as Page;
            page.BindingContext = viewModel;
            pageService.PushAsync(page);
        }
    }
}