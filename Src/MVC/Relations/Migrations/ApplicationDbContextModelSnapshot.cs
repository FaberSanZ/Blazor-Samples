﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Relations.Data;

namespace Relations.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("Relations.Data.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UniversityId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Relations.Data.Entities.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Code")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("Relations.Data.Entities.Course", b =>
                {
                    b.HasOne("Relations.Data.Entities.University", "University")
                        .WithMany("Groups")
                        .HasForeignKey("UniversityId");
                });
#pragma warning restore 612, 618
        }
    }
}