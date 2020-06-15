using CMSE406_OutlineSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Data
{
    public class Repo : IRepo
    {
        private readonly DataContext _dataContext;

        public Repo(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public async Task<List<StudyProgram>> GetStudyPrograms()
        {
            var studyPrograms = await _dataContext.StudyPrograms
                                        .Include(x=>x.Courses)
                                        .ThenInclude(y=>y.Prerequisites)
                                        .ToListAsync();
            return studyPrograms;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _dataContext.Users.ToListAsync();
        }
        public async Task<User> GetUser(int userId)
        {
            var user = await _dataContext.Users.FirstOrDefaultAsync(u => u.Id == userId);

            return user;

        }

        public async Task AddFiles(string courseCode, File fileToSave)
        {
            
            
           
            var course = await _dataContext.Courses.FirstOrDefaultAsync(c => c.CourseCode == courseCode);
             if (course.Files == null) course.Files = new List<File>();
            course.Files.Add(fileToSave);

       
        
            
        }
        public async Task<bool> SaveAll()
        {
            return await _dataContext.SaveChangesAsync() > 0;
        }

        public async Task<File> GetFile(int id)
        {
            return await _dataContext.Files.FirstOrDefaultAsync(x=>x.Id==id);
        }

        public async Task<List<File>> GetCourseFiles(string courseCode)
        {
            var course= await _dataContext.Courses.Include(x=>x.Files).FirstOrDefaultAsync(x => x.CourseCode == courseCode);
            return course.Files;
        }

        public async Task<List<Course>> GetCourses(int userId)
        {
            return await _dataContext.Courses.Where(x => x.InstructorID == userId).ToListAsync();
        }

        public async Task<bool> CheckCourse(string courseCode,int userId)
        {
            var courses = await _dataContext.Courses.Where(x => x.CourseCode == courseCode).ToListAsync();
            foreach(Course course in courses)
            {
                if (course.InstructorID == userId) return true;
            }
            return false;
        }


        public void Delete<T>(T entity) where T : class
        {
            this._dataContext.Remove(entity);
        }
        public async Task<List<StudentLO>> GetStudentLO(){
            return await _dataContext.StudentLOs.ToListAsync();
        }
    }
}
