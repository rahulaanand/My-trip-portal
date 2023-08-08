﻿// <auto-generated />
using MakemyTrip.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MakemyTrip.Migrations
{
    [DbContext(typeof(AdminContext))]
    [Migration("20230731121454_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MakemyTrip.Models.Admin", b =>
                {
                    b.Property<int>("Admin_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Admin_Id"));

                    b.Property<string>("Admin_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Admin_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Admin_Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Admin_Id");

                    b.ToTable("Admins");
                });
#pragma warning restore 612, 618
        }
    }
}
