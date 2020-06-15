using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Models
{
    public class CourseSemesterDetail
    {
        public int Id { get; set; }

        public string CourseCode { get; set; }
        public int Rcode { get; set; }
        public string YearSemester { get; set; }
        public string TextBook { get; set; }
        public string IndicativeBasicReadingList { get; set; }
        public string MeetingTimePlace { get; set; }

        public int InstructorId { get; set; }
        public int AssistantId { get; set; }

        public int AttendanceGrade { get; set; }
        public string MakeupPolicy { get; set; }
        public string NgGradePolicy { get; set; }
        public string MissedLabPolicy { get; set; }
        public CourseSemesterWeeklySchedule CourseSemesterWeeklySchedule { get; set; }
        public CourseAssessment CourseAssessment { get; set; }



    }
}
