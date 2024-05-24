using MRQ.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MRQ.ViewModels
{
    public partial class DietTypeViewModel : ObservableObject
    {
        [ObservableProperty]
        private string selectedDietType = string.Empty;

        [ObservableProperty]
        private ObservableCollection<string> dietTypes = new ObservableCollection<string>
        {
            "Vegan",
            "Vegetarian",
            "Flexitatiran",
            "Pescatarian",
            "Omnivorous"
        };

        [RelayCommand]
        private async Task NextCommand()
        {
            // Navigate to the SustainableCommutePage
            await Shell.Current.GoToAsync(nameof(SustainableCommutePage));
        }
    }
}
