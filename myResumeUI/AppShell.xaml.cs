namespace myResumeUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.AddEditAcademic), typeof(Views.AddEditAcademic));
    }
}
