using MRQ.Models;
using System.Collections.ObjectModel;

namespace MRQ.ViewModels
{
    public class ExpensesViewModel
    {
        public ObservableCollection<ExpenseItem> Expenses { get; } = null!;

        public ExpensesViewModel()
        {
            Expenses = new ObservableCollection<ExpenseItem>
            {
                new ExpenseItem {IconImageSource = "car.svg", Title = "Car", CarbonAmount = 6.40, Date = "19 Mar."},
                new ExpenseItem {IconImageSource = "food.svg", Title = "Food", CarbonAmount = 7, Date = "17 Mar."},
                new ExpenseItem {IconImageSource = "energy.svg", Title = "Energy", CarbonAmount = 30.20, Date = "15 Mar."},
                new ExpenseItem {IconImageSource = "plane.svg", Title = "Plane", CarbonAmount = 70.40, Date = "12 Mar."},
                new ExpenseItem {IconImageSource = "flame.svg", Title = "Gas", CarbonAmount = 0.40, Date = "10 Mar."},
                new ExpenseItem {IconImageSource = "shopping.svg", Title = "Shopping", CarbonAmount = 0.30, Date = "12 Feb."},

            };
        }

    }
}
