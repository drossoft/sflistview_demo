namespace sflistview_demo.Views;

public partial class Page2Page : ContentPage
{
	public Page2Page(Page2ViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
