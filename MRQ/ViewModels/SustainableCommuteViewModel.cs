using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRQ.ViewModels
{
    public partial class SustainableCommuteViewModel : ObservableObject
    {
        [ObservableProperty]
        private double sustainableCommutePercentage;
    }
}
