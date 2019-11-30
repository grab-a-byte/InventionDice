using InventionDice.ViewModels;

namespace InventionDice.Services.Navigation
{
    public interface INavigationService
    {
        void NavigateTo<TViewModel>() where TViewModel : ViewModelBase;
        void NavigateTo<TViewModel>(TViewModel viewModel) where TViewModel : ViewModelBase;

        void NavigateAsRoot<TViewModel>() where TViewModel : ViewModelBase;
    }
}
