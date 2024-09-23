﻿// <auto-generated />
using System;
using ActivityMonitorAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ActivityMonitorAPI.Migrations
{
    [DbContext(typeof(ActivityDBContext))]
    [Migration("20240923135557_ef-add-users")]
    partial class efaddusers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.1.24451.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActivityMonitorAPI.Activity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("activityDescription")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("nameActivity")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.HasKey("id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("ActivityMonitorAPI.ActivityCategory", b =>
                {
                    b.Property<string>("catName")
                        .HasColumnType("varchar(100)");

                    b.HasKey("catName");

                    b.ToTable("ActivityCategory");
                });

            modelBuilder.Entity("ActivityMonitorAPI.ActivityDuration", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("activityId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("durationTime")
                        .HasColumnType("time");

                    b.Property<DateTime>("startTime")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("ActivityCategories");
                });

            modelBuilder.Entity("ActivityMonitorAPI.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
