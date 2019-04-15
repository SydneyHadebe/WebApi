using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirstProject.Models
{
    //Add-Migration EFCoreCodeFirstProject.Models.AddEmployeeGender
    //update-database EFCoreCodeFirstProject.Models.EmployeeContextSeed
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Sydney",
                LastName = "Hadebe",
                Email = "uncle.bob@gmail.com",
                DateOfBirth = new DateTime(1988, 01, 31),
                PhoneNumber = "078-516-7788",
                Gender = "M"

            }, new Employee
            {
                EmployeeId = 2,
                FirstName = "Practice",
                LastName = "Ndlovu",
                Email = "Simbo.Sbu@gmail.com",
                DateOfBirth = new DateTime(2008, 01, 04),
                PhoneNumber = "078-469-9153",
                Gender = "M"
            });

            modelBuilder.Entity<Profession>().HasData(new Profession
            {
                 ProfessionId = 1,
                 EmployeeId = 1, 
                   Title = "Software Developer",
                    Speciality = "Web Services(Backend)"
            }, 
            new Profession
            {
                ProfessionId = 2,
                EmployeeId = 2,
                Title = "Web Api Developer",
                Speciality = "Mobile Services(Backend)"
            });
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Profession> Professions { get; set; }

    }
}
