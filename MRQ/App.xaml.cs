using MRQ.Pages;

namespace MRQ
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            Shell.Current.GoToAsync(nameof(DietTypePage));
        }
    }
}
