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
        public string SloCode { get; set; }
        public string StudentLearningOutcomes { get; set; }
    }
}
