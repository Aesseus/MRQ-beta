using System.Windows.Input;
using MRQ.Pages;
using Microsoft.Maui.Controls;

namespace MRQ.ViewModels
{
    public class MainPageViewModel : BaseViewModel 
    {
        public ICommand ReviewExpensesCommand { get; }

        public MainPageViewModel()
        {
            ReviewExpensesCommand = new Command(OnReviewExpensesClicked);
        }

        private async void OnReviewExpensesClicked()
        {
            // Navigation using Shell, adjust if using a different navigation approach
            // Using a route name
            await Shell.Current.GoToAsync("///expensesPage");
        }
    }
}
