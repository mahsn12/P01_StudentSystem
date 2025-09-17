using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.model
{
    class HomeWorkSubmissions
    {
        [Key]
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public string ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public Course course { get; set; }
        public int courseID { get; set; }
        public Students student { get; set; }
        public int studentID { get; set; }
    }
}
