using myResumeUI.ViewModel;

namespace myResumeUI.Views;
[QueryProperty(nameof(UserID), nameof(UserID))]

public partial class AddEditAcademic : ContentView
{
	private long _userId;

	public long UserID {
		get => _userId;
		set
		{
			if (value != null)
				_userId = value;
		}
	}
    public AddEditAcademic()
	{
		InitializeComponent();
		BindingContext = new AddEditAcademicViewModel(UserID);

    }
}