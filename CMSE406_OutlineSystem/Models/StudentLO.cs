using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Models
{
    public class StudentLO
    {
        [Key]
        public int SloCode { get; set; }
        public string StudentLearningOutcome { get; set; }
    }
}
