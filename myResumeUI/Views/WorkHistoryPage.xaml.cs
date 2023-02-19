using myResumeUI.ViewModel;

namespace myResumeUI.Views;

public partial class WorkHistoryPage : ContentPage
{
	public WorkHistoryPage()
	{
		InitializeComponent();
        BindingContext = new WorkHistoryViewModel();
    }

    protected override void OnAppearing()
    {
        BindingContext = new WorkHistoryViewModel();
    }
}