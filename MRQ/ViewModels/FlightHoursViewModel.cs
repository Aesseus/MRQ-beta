using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRQ.ViewModels
{
    public partial class FlightHoursViewModel : ObservableObject
    {
        [ObservableProperty]
        private int flightHours;        

        [RelayCommand]
        private async Task NextCommand()
        {
            // Navigate to the SustainableCommutePage
            await Shell.Current.GoToAsync("///DietTypePage");
        }
    }
}
