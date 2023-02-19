using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myResumeUI.Models
{
    public class WorkHistory
    {
        public long iD { get; set; }
        public long userId { get; set; }
        public string position { get; set; }
        public string companyName { get; set; }
        public string workDescription { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isCurrentJob { get; set; }
    }
}
