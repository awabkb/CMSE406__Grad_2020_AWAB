using CMSE406_OutlineSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Data
{
    public interface IRepo
    {
       public Task<List<StudyProgram>> GetStudyPrograms();
       public Task<List<User>> GetUsers();
        public Task<User> GetUser(int userId);
        public Task AddFiles(string courseCode,File fileToSave);
        public Task<bool> SaveAll();
        public Task<File> GetFile(int id);
        void Delete<T>(T entity) where T : class;
        public Task<List<File>> GetCourseFiles(string courseCode);
        public Task<List<Course>> GetCourses(int userId);
        public Task<bool> CheckCourse(string courseCode,int userId);
        public Task<List<StudentLO>> GetStudentLO();
    }
}
