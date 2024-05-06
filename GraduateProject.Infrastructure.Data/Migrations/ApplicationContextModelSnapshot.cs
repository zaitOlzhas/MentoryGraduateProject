﻿// <auto-generated />
using System;
using GraduateProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraduateProject.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GraduateProject.Domain.Core.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("efd27265-0268-4b23-b35b-8e7e234683bd"),
                            Description = "Description of a book.",
                            Name = "Tom",
                            Price = 37
                        },
                        new
                        {
                            Id = new Guid("c4204024-8247-4588-9df9-7e335497938b"),
                            Description = "Description of a book.",
                            Name = "Bob",
                            Price = 41
                        },
                        new
                        {
                            Id = new Guid("1127cdea-dcad-4350-b53f-a07f70d3ee26"),
                            Description = "Description of a book.",
                            Name = "Sam",
                            Price = 24
                        });
                });

            modelBuilder.Entity("GraduateProject.Domain.Core.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GraduateProject.Domain.Core.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6634994b-7dc5-4338-87ea-1590bee5f41f"),
                            Login = "qwe",
                            Password = "qwe"
                        },
                        new
                        {
                            Id = new Guid("49108f76-0090-4db0-b299-872fe4298426"),
                            Login = "asd",
                            Password = "asd"
                        });
                });

            modelBuilder.Entity("GraduateProject.Domain.Core.Order", b =>
                {
                    b.HasOne("GraduateProject.Domain.Core.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraduateProject.Domain.Core.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
