using MRQ.ViewModels;

namespace MRQ.Pages;

public partial class DietTypePage : ContentPage
{
	public DietTypePage()
	{
		InitializeComponent();
		BindingContext = new DietTypeViewModel();
	}
}