using CMSE406_OutlineSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<AssessmentType> AssessmentTypes { get; set; }
        public DbSet<ClassTime> ClassTimes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseAssessment> CourseAssessments { get; set; }
        public DbSet<CourseLO> CourseLOs { get; set; }
        public DbSet<CourseSemesterDetail> CourseSemesterDetails { get; set; }
        public DbSet<CourseSemesterWeeklySchedule> CourseSemesterWeeklySchedules { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Prerequisite> Prerequisites { get; set; }
        public DbSet<StudentLO> StudentLOs { get; set; }    
        public DbSet<StudyProgram> StudyPrograms { get; set; }
        public DbSet<User> Users { get; set; }
        
        
        

    }
}
