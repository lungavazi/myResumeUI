using Newtonsoft.Json;

namespace myResumeUI.Models
{
    public class AboutMe
    {
        public long id { get; set; }
        public string userName { get; set; }
        public string title { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public Char Gender { get; set; }
        public string address { get; set; }
        public bool isProfileActive { get; set; }
        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<WorkHistory> WorkHistory { get; set; }
    }
}
