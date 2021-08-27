using CourseRegistration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.SqlRepo
{
    public class AppDbContext : DbContext
    {
      public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        public DbSet<Course> Courses { set; get; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseStudents> CourseStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().HasData(
            new Course { CourseId = 1001, C_Number = 1, C_Name = "Math", Description = "Geometry" },
            new Course { CourseId = 1002, C_Number = 2, C_Name = "Science", Description = "Biology" },
            new Course { CourseId = 1003, C_Number = 3, C_Name = "Computer Science", Description = "Web Development" }

                );
            modelBuilder.Entity<Instructor>().HasData(
            new Instructor { I_Id = 101, FirstName = "Mark", LastName = "Johnson", EmailAddress = "markjohnson@gmail.com"},
            new Instructor { I_Id = 102, FirstName = "Lucy", LastName = "Smith", EmailAddress = "lucysmith@gmail.com" },
            new Instructor { I_Id = 103, FirstName = "Trecy", LastName = "Brown", EmailAddress = "trecybrown@gmail.com" }
                );

            modelBuilder.Entity<Student>().HasData(
            new Student { StudentId = 001, FirstName = "Danial", LastName = "Para", EmailAddress = "danialpara@gmail.com", PhoneNumber = "5879207077" },
            new Student { StudentId = 002, FirstName = "Parker", LastName = "James", EmailAddress = "parkerjames@gmail.com", PhoneNumber = "7809304545" },
            new Student { StudentId = 003, FirstName = "Robin", LastName = "Smith", EmailAddress = "robinsmith@gmail.com", PhoneNumber = "6785674564"},
            new Student { StudentId = 004, FirstName = "Sura", LastName = "Tandan", EmailAddress = "suratandan@gmail.com", PhoneNumber = "2785674504" },
            new Student { StudentId = 005, FirstName = "Samuel", LastName = "Johnson", EmailAddress = "samueljohnson@gmail.com", PhoneNumber = "6785644560" },
            new Student { StudentId = 006, FirstName = "Tommy", LastName = "Lee", EmailAddress = "tommylee@gmail.com", PhoneNumber = "4785684564" }


                );

        }
    }
}
