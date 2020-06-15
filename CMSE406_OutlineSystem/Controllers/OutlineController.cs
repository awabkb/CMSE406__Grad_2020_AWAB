using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using CMSE406_OutlineSystem.Data;
using CMSE406_OutlineSystem.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CMSE406_OutlineSystem.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class OutlineController : Controller
    {
        private readonly IRepo _repo;
        private readonly IMapper _mapper;

        public OutlineController(IRepo repo, IMapper mapper)
        {
            this._repo = repo;
            this._mapper = mapper;
        }

        [HttpGet("studyprograms")]
        public async Task<IActionResult> GetStudyPrograms()
        {
            var studyProgramsToReturn = await _repo.GetStudyPrograms();
           
            return Ok(studyProgramsToReturn);
        }
        [HttpGet("assistants")]
        public async Task<IActionResult> GetAssistants()
        {
            var userFromRepo = await _repo.GetUsers();
            var assistantsToReturn = _mapper.Map<IEnumerable< UserForAssistantDto>>(
                                    userFromRepo.FindAll(x=>x.TypeOfUser=="assistant"));
            return Ok(assistantsToReturn);
        }
        [HttpGet("{id}", Name = "GetUser")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repo.GetUser(id);

            var userToReturn = _mapper.Map<UserForAssistantDto>(user);


            return Ok(userToReturn);
        }

    }
}