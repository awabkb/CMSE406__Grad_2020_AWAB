using System;
using System.ComponentModel.DataAnnotations;

namespace CMSE406_OutlineSystem.Models
{
    public class ClassTime
    {
        [Key]
        public string CourseCode { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
    }
}