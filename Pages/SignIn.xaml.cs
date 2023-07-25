namespace TODO.Pages;

public partial class SignIn : ContentPage
{
	public SignIn()
	{
		InitializeComponent();
	}

    private async void OnSignInClicked(object sender, EventArgs e)
    {
        if(txtEmail.Text?.Length == 0 || txtPassword.Text?.Length == 0)
        {
            await DisplayAlert("Alert", "Email or Password cannot be empty", "Retry");
            return;
        }

        Application.Current.MainPage = new MainPage();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Register));
    }

    private async void OnForgetPasswordClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ForgetPassword));
    }
}