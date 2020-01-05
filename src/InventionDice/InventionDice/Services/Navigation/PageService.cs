using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InventionDice.Services.Navigation
{
    public class PageService : IPageService
    {
        public Page CurrentPage => Navigation.NavigationStack.LastOrDefault();
        public Page Main => Application.Current.MainPage ?? (Application.Current.MainPage = new NavigationPage(new ContentPage()));

        public void PushAsRoot(Page page) =>
            Application.Current.MainPage = page;

        public async Task PushAsync(Page page) =>
            await Navigation.PushAsync(page);

        public async Task<Page> PopAsync()
            => await Navigation.PopAsync();

        private INavigation Navigation => Main.Navigation;
    }
}