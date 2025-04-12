﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using firstdotnet.Data;

#nullable disable

namespace firstdotnet.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250412073816_seed categories")]
    partial class seedcategories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("firstdotnet.Models.Category", b =>
                {
                    b.Property<int>("Cateogry_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cateogry_Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cateogry_Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Cateogry_Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Cateogry_Id = 2,
                            DisplayOrder = 1,
                            Name = "SciFi"
                        },
                        new
                        {
                            Cateogry_Id = 3,
                            DisplayOrder = 1,
                            Name = "Comedy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
