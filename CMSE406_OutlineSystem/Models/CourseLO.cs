using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Models
{
    public class CourseLO
    {
        [Key]
        public int CloCode { get; set; }
        public string CourseLearningOutcomes { get; set; }
        public string CourseCode { get; set; }
        public int Rcode { get; set; }
        public string YearSemester { get; set; }
    }
}
