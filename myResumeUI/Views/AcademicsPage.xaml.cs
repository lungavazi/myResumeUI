using myResumeUI.Models;
using myResumeUI.Service;
using myResumeUI.ViewModel;
using System.Collections.ObjectModel;

namespace myResumeUI.Views;

public partial class AcademicsPage : ContentPage
{ 
    public AcademicsPage()
	{
		InitializeComponent();

        BindingContext = new AcademicsViewModel();
    }

    protected override void OnAppearing()
    {
        BindingContext = new AcademicsViewModel();
    }
}

