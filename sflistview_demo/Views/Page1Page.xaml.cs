namespace sflistview_demo.Views;

public partial class Page1Page : ContentPage
{
	public Page1Page(Page1ViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
