﻿// <auto-generated />
using System;
using EFCoreCodeFirstProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreCodeFirstProject.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20190413085938_EFCoreCodeFirstProject.Models.AddEmployeeGender")]
    partial class EFCoreCodeFirstProjectModelsAddEmployeeGender
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreCodeFirstProject.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1L,
                            DateOfBirth = new DateTime(1988, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "uncle.bob@gmail.com",
                            FirstName = "Sydney",
                            LastName = "Hadebe",
                            PhoneNumber = "078-516-7788"
                        },
                        new
                        {
                            EmployeeId = 2L,
                            DateOfBirth = new DateTime(2008, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Simbo.Sbu@gmail.com",
                            FirstName = "Practice",
                            LastName = "Ndlovu",
                            PhoneNumber = "078-469-9153"
                        });
                });

            modelBuilder.Entity("EFCoreCodeFirstProject.Models.Profession", b =>
                {
                    b.Property<int>("ProfessionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("EmployeeId");

                    b.Property<string>("Speciality");

                    b.Property<string>("Title");

                    b.HasKey("ProfessionId");

                    b.ToTable("Professions");

                    b.HasData(
                        new
                        {
                            ProfessionId = 1,
                            EmployeeId = 1L,
                            Speciality = "Web Services(Backend)",
                            Title = "Software Developer"
                        },
                        new
                        {
                            ProfessionId = 2,
                            EmployeeId = 2L,
                            Speciality = "Mobile Services(Backend)",
                            Title = "Web Api Developer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
