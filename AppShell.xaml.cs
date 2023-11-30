namespace Escobar_AppApuntes;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.NotePage1), typeof(Views.NotePage1));
    }
}
