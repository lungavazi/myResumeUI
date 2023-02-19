
using myResumeUI.Models;
using myResumeUI.Service;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace myResumeUI.ViewModel
{
    public class AboutMeViewModel
    {
        private MyResumeSercive service = new MyResumeSercive();
        public AboutMe AboutMe = new AboutMe();
        public ICommand EditAboutMeCommand { get; set; }

        public AboutMeViewModel()
        {
            EditAboutMeCommand = new Command(async () => await EditAboutMe());
            LoadABoutMe();
        }

        private async Task EditAboutMe()
        {
            await Shell.Current.GoToAsync("");
        }

        public async void LoadABoutMe()
        {
            try
            {
                var aboutMe = new AboutMe();
                var results =  await service.GetAboutMe();
                //var results = task.Result;
                if (results != null)
                {
                    AboutMe = results;
                }
            }
            catch (Exception ex)
            {
                //return new AboutMe();
                throw;
            }
        }
    }
}
