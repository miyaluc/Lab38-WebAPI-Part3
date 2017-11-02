﻿// <auto-generated />
using lab36_miya.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace lab36_miya.Migrations
{
    [DbContext(typeof(Lab36DbContext))]
    partial class Lab36DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("lab36_miya.Models.Majors", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("lab36_miya.Models.RequiredCoursework", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<bool>("IsComplete");

                    b.Property<int>("ListID");

                    b.Property<int?>("MajorsID");

                    b.HasKey("ID");

                    b.HasIndex("MajorsID");

                    b.ToTable("RequiredCoursework");
                });

            modelBuilder.Entity("lab36_miya.Models.RequiredCoursework", b =>
                {
                    b.HasOne("lab36_miya.Models.Majors")
                        .WithMany("Courses")
                        .HasForeignKey("MajorsID");
                });
#pragma warning restore 612, 618
        }
    }
}
