using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.model
{
    class Students
    {
        [Key]
        public int StudentID { set; get; }
        public DateOnly birthday { set; get; }
        public string name { set; get; }
        public int PhoneNum { set; get; }
        public DateOnly registerdOn { set; get; }
        public List<Course> Courses { set; get; }
        public List<HomeWorkSubmissions> submissions { set; get; }
    }
}
