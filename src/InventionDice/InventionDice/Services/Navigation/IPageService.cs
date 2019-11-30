using System.Threading.Tasks;
using Xamarin.Forms;

namespace InventionDice.Services.Navigation
{
    public interface IPageService
    {
        Page CurrentPage { get; }
        Page Main { get; }
        void PushAsRoot(Page page);
        Task PushAsync(Page page);
        Task<Page> PopAsync();
    }
}
