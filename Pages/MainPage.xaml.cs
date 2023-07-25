using TODO.ViewModel;

namespace TODO.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        BindingContext = new MainPageViewModel();
    }
}