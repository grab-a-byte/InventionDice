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
        public async void NavigateTo<TViewModel>() where TViewModel : ViewModelBase
        {
            Type viewType = viewViewModelMappings.GetViewType<TViewModel>();
            object view = Activator.CreateInstance(viewType);
            Page page = view as Page;
            TViewModel viewModel = viewModelFactory.GetViewModel<TViewModel>();
            page.BindingContext = viewModel;
            await pageService.PushAsync(page);
            viewModel.Initialise();
        }

        public async void NavigateTo<TViewModel>(TViewModel viewModel) where TViewModel : ViewModelBase
        {
            Type viewType = viewViewModelMappings.GetViewType<TViewModel>();
            object view = Activator.CreateInstance(viewType);
            Page page = view as Page;
            page.BindingContext = viewModel;
            await pageService.PushAsync(page);
        }

        public void NavigateAsRoot<TViewModel>() where TViewModel : ViewModelBase
        {
            var viewType = viewViewModelMappings.GetViewType<TViewModel>();
            var view = Activator.CreateInstance(viewType);
            var page = view as Page;
            var navPage = new NavigationPage(page);
            TViewModel viewModel = viewModelFactory.GetViewModel<TViewModel>();
            page.BindingContext = viewModel;
            pageService.PushAsRoot(navPage);
            viewModel.Initialise();
        }
    }
}