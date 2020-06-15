using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Models
{
    public class CourseSemesterWeeklySchedule
    {
        public int Id { get; set; }

        public string CourseCode { get; set; }
        public int Rcode { get; set; }
        public string YearSemester { get; set; }
        public int WeekNo { get; set; }
        public DateTime Date { get; set; }
        public string LectureTopic { get; set; }
        public string LabTopic { get; set; }
    }
}
