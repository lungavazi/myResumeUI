using myResumeUI.Models;
using myResumeUI.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myResumeUI.ViewModel
{
    public class AddEditAcademicViewModel
    {
            public Education Education { get; set; } = new Education();
        //public event PropertyChangedEventHandler PropertyChanged;
        private MyResumeSercive service = new MyResumeSercive();
        public AddEditAcademicViewModel(long userId)
        {
            LoadAcademic(userId);
        }

        private async void LoadAcademic(long userId)
        {
            var results = await service.GetAcademicById(userId);
            if (results != null ) { Education = results; }
        }
    }
}
