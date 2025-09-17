using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.model
{
    class Resources
    {
        [Key]
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string ResourceType { get; set; }
        public string Url { get; set; }
        public Course course { set; get; }
        public int courseID { set; get; }
    }
}
