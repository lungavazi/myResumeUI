using myResumeUI.Models;
using myResumeUI.Service;
using myResumeUI.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace myResumeUI.ViewModel
{
    public class AcademicsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Education> Educations { get; set; } = new ObservableCollection<Education> { };
        public event PropertyChangedEventHandler PropertyChanged;
        private MyResumeSercive service = new MyResumeSercive();
        public ICommand AddEducationCommand { get; set; }
        private Education _education;

        public AcademicsViewModel()
        {
            AddEducationCommand = new Command(async () => await AddEducation());
            LoadAcademics();
        }

        private async Task AddEducation()
        {
            await Shell.Current.GoToAsync($"{nameof(AddEditAcademic)}?{nameof(AddEditAcademic.UserID)}={0}");
        }

        private async void LoadAcademics()
        {
            Educations.Clear();
            var results = await service.GetAcademicsByUserId(6);
            if (results != null)
                foreach (var item in results)
                    Educations.Add(item);
        }

        public Education SelectedEducation
        {
            get => _education = Educations.FirstOrDefault();
            set
            {
                if (value != null)
                {
                    _education = value;
                    //EditEducation();
                }
            }
        }
    }
}
