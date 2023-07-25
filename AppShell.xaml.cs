using TODO.Pages;

namespace TODO;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		RegisterRoutes();
	}

	private static void RegisterRoutes()
	{
		Routing.RegisterRoute(nameof(SignIn), typeof(SignIn));
		Routing.RegisterRoute(nameof(Register), typeof(Register));
		Routing.RegisterRoute(nameof(ForgetPassword), typeof(ForgetPassword));
		Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
	}
}
