using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Models
{
    public class CourseAssessment
    {
        
        public string CourseCode { get; set; }
        public int Rcode { get; set; }
        public string YearSemester { get; set; }
        [Key]
        public string AssessmentCode { get; set; }
        public int Percentage { get; set; }
        public AssessmentType AssessmentType { get; set; }
    }
}
