using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Dtos
{
    public class UserForAssistantDto
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
      
        public string Title { get; set; }
        public string Office { get; set; }
        public string OfficeTel { get; set; }
        public string Email { get; set; }
    }
}
