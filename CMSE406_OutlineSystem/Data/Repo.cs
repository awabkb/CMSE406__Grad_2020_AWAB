using CMSE406_OutlineSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
