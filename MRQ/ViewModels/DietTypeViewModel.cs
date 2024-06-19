using MRQ.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MRQ.Services;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MRQ.ViewModels
{
    public partial class DietTypeViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        private string _selectedDietType = string.Empty;
        public string SelectedDietType
        {
            get => _selectedDietType;
            set => SetProperty(ref _selectedDietType, value);
        }

        private ObservableCollection<string> _dietTypes = new ObservableCollection<string>
        {
            "Vegan",
            "Vegetarian",
            "Flexitatiran",
            "Pescatarian",
            "Omnivorous"
        };
        public ObservableCollection<string> DietTypes
        {
            get => _dietTypes;
            set => SetProperty(ref _dietTypes, value);
        }

        public ICommand NextCommand { get; }

        public DietTypeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NextCommand = new Command(async () => await NextCommandExecute());
        }

        private async Task NextCommandExecute()
        {
            try
            {
                Debug.WriteLine("NextCommand Executed");
                // Navigate to the SustainableCommutePage
                await _navigationService.NavigateToAsync(nameof(SustainableCommutePage));
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Navigation failed: {ex.Message}");
            }
        }
    }
}