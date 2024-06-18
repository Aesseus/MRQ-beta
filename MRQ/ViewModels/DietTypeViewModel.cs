using MRQ.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


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
            try 
            {
                Debug.WriteLine("NextCommand Executed");
                // Navigate to the SustainableCommutePage
                await Shell.Current.GoToAsync(nameof(SustainableCommutePage));
            }
            catch (Exception ex) 
            {
                Debug.WriteLine($"Navigation failed: {ex.Message}");
            }
        }

        // ... Rest of the code ...

    }
}

