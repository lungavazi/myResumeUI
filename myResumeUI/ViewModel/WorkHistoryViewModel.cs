using myResumeUI.Models;
using myResumeUI.Service;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace myResumeUI.ViewModel
{
    public class WorkHistoryViewModel
    {
        public ObservableCollection<WorkHistory> WorkHistory { get; set; } = new ObservableCollection<WorkHistory> { };
        private MyResumeSercive service = new MyResumeSercive();
        private WorkHistory _work;
        public ICommand AddHistoryCommand {get; set;}

        public WorkHistoryViewModel() {
            AddHistoryCommand = new Command(async () => await AddWork());
            LoadAcademics();
        }

        private async void LoadAcademics()
        {
            WorkHistory.Clear();
            var results = await service.GetWorkHistiry(6);
            if (results != null)
                foreach (var item in results)
                    WorkHistory.Add(item);

            _work = WorkHistory.FirstOrDefault();
        }

        public async Task AddWork()
        {
            await Shell.Current.GoToAsync("");
        }

        public WorkHistory SelectedWork
        {
            get => _work;
            set
            {
                if (value != null)
                {
                    _work = value;
                }
            }
        }
    }
}
