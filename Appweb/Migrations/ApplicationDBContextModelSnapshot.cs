﻿// <auto-generated />
using Appweb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Appweb.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Appweb.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayPriority")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Give you a feel of challenge",
                            DisplayPriority = 1,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 2,
                            Description = "So romantique",
                            DisplayPriority = 4,
                            Name = "Roman"
                        },
                        new
                        {
                            Id = 3,
                            Description = "So scary",
                            DisplayPriority = 3,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            Description = "So interesting",
                            DisplayPriority = 2,
                            Name = "Scifi"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
