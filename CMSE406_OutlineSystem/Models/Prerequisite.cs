using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Models
{
    public class Prerequisite
    {
        [Key]
        public string PreCourseCode { get; set; }
        public string PreCourseName { get; set; }
    }
}
