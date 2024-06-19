using MRQ.ViewModels;

namespace MRQ.Pages
{
	public partial class DietTypePage : ContentPage
	{
		public DietTypePage(DietTypeViewModel viewModel)
		{
			InitializeComponent();
			BindingContext = viewModel;
		}
	}
}