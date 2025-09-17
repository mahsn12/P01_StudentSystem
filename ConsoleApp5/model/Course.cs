using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.model
{
    class Course
    {
        [Key]
        public int CourseID { set; get; }
        public string description { set; get; }
        public DateOnly endDate { set; get; }
        public string name { set; get; }
        public float price { set; get; }
        public DateOnly startDate { set; get; }

        public List<Students> students { set; get; }
        public List<HomeWorkSubmissions> submissions { set; get; }
        public List<Resources>resource { set; get; }
    }
}
