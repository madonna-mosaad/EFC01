using EFC01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC01.Contexts
{
    internal class DepartmentDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-2AMJ5HN ; Database = ITIEFC ; Trusted_Connection = True ; Encrypt = False");
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }  
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Topic> topics { get; set; }
    }
}
