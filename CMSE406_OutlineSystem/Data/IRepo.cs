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
    }
}
