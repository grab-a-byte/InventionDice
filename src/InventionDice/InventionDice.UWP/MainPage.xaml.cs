namespace InventionDice.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new InventionDice.App());
        }
    }
}
