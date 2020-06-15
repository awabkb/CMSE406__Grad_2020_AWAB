using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Models
{
    public class StudyProgram
    {
        [Key]
        public int ProgramCode { get; set; }
        public string ProgramName { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
