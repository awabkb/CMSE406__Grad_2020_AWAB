using AutoMapper;
using CMSE406_OutlineSystem.Dtos;
using CMSE406_OutlineSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() {
            CreateMap<User, UserForListDto>();
            CreateMap<User, UserForAssistantDto>();
            
                
        }

    }
}
