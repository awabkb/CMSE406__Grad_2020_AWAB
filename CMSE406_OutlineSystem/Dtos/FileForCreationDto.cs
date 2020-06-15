using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Dtos
{
    public class FileForCreationDto
    {
        public string Url { get; set; }
        public IFormFile File { get; set; }
        public int DesId {get;set;}
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; }

        public string CourseCode { get; set; }
        public FileForCreationDto()
        {
            DateAdded = DateTime.Now;
        }
    }
}
