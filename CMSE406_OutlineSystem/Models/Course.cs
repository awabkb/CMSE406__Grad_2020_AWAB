using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Models
{
    public class Course
    {
        [Key]
        public string CourseCode { get; set; }
        public int Rcode { get; set; }
        public string Name { get; set; }

        public IEnumerable<Prerequisite> Prerequisites { get; set; }
        public string ReqOrElc { get; set; }

        public IEnumerable<ClassTime> LectureTime { get; set; }
        public ClassTime LabTime { get; set; }
        public int Credits { get; set; }

        public int Ects { get; set; }
        public string Semester { get; set; }
        public string Department { get; set; }

        public string CourseDescription { get; set; }

        [Url]
        public string CourseWebpage { get; set; }

        public CourseSemesterDetail CourseSemesterDetails { get; set; }
        public CourseLO CourseLO { get; set; }



    }
}
