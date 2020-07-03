using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using CMSE406_OutlineSystem.Data;
using CMSE406_OutlineSystem.Dtos;
using CMSE406_OutlineSystem.Helpers;
using CMSE406_OutlineSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CMSE406_OutlineSystem.Controllers
{
    [Authorize]
    [Route("[controller]/{userId}")]
    [ApiController]
    public class FilesController : Controller
    {
        private readonly IRepo _repo;
        public   IMapper _mapper { get; }
        private readonly IOptions<CloudinarySettings> _cloudinaryConfig;
        private Cloudinary _cloudinary;

        public FilesController(IRepo repo,IMapper mapper
                        , IOptions<CloudinarySettings> cloudinaryConfig)
        {
            _repo = repo;
            _mapper = mapper;
            _cloudinaryConfig = cloudinaryConfig;

            Account acc = new Account(
                _cloudinaryConfig.Value.CloudName,
                _cloudinaryConfig.Value.ApiKey,
                _cloudinaryConfig.Value.ApiSecret);

            _cloudinary = new Cloudinary(acc);
        }
        
        [HttpGet("File/{id}",Name ="GetFile")]
        public async Task<IActionResult> GetFile(int userId,int id)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();
            var fileFromRepo = await _repo.GetFile(id);
            return Ok(fileFromRepo);
        }
        
        [HttpGet("{courseCode}",Name ="GetCourseFiles")]
        public async Task<IActionResult> GetAllFiles(int userId,string courseCode)
        {
           var filesToReturn = await _repo.GetCourseFiles(courseCode);
            return Ok(filesToReturn);
        }
        
        [HttpPost]
        public async Task<IActionResult> SaveFiles(int userId, 
                                [FromForm] FileForCreationDto fileForCreationDto)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();

            
            var file =fileForCreationDto.File;
            var uploadResult = new RawUploadResult();

            if (file.Length > 0)
            {
                using(var stream = file.OpenReadStream())
                {
                    var uploadParams = new RawUploadParams()
                    {
                        File = new FileDescription(file.Name, stream)
                    };
                     uploadResult = _cloudinary.Upload(uploadParams);

                };
            }
            fileForCreationDto.PublicId= uploadResult.PublicId;
            fileForCreationDto.Url = uploadResult.Url.ToString();

            var fileToSave = _mapper.Map<File>(fileForCreationDto);
            await _repo.AddFiles(fileForCreationDto.CourseCode, fileToSave);

            if(await _repo.SaveAll())
            {
                return Ok();
            }
            return BadRequest("Couldn't save the file");

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFile(int id, int userId)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();

            var fileFromRepo = await _repo.GetFile(id);
            if (fileFromRepo.PublicId != null)
            {
                var result = _cloudinary.Destroy(new DeletionParams(fileFromRepo.PublicId));

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    _repo.Delete(fileFromRepo);
                }
            }
            else
            {
                _repo.Delete(fileFromRepo);
            }

            if (await _repo.SaveAll())
            {
                return Ok();
            }

            return BadRequest("Failed to delete the photo");
        

    }

}
}
