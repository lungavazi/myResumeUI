using myResumeUI.Models;
using myResumeUI.Service;
using myResumeUI.ViewModel;

namespace myResumeUI.Views;

public partial class AboutPage : ContentPage
{
    
	public AboutPage()
	{
		InitializeComponent();
        BindingContext = new AboutMeViewModel();
    }

    protected override void OnAppearing()
    {
        BindingContext = new AboutMeViewModel();
    }

   
}