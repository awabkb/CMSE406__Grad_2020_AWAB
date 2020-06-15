using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Models
{
    public class AssessmentType
    {
        [Key]
        public string AssessmentCode { get; set; }
        public string AssessmentName { get; set; }
    }
}
