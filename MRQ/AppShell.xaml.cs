using MRQ.Pages;

namespace MRQ
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Shell.SetNavBarIsVisible(this, true);

        }
    }
}
