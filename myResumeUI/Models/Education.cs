using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myResumeUI.Models
{
    public class Education
    {
        public long id { get; set; }
        public long userId { get; set; }
        public string qualificationName { get; set; }
        public string institutionName { get; set; }
        public string qualificationLevel { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public string status { get; set; }
    }
}
