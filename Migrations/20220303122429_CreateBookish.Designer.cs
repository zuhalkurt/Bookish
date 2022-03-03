﻿// <auto-generated />
using System;
using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bookish.Migrations
{
    [DbContext(typeof(BookishContext))]
    [Migration("20220303122429_CreateBookish")]
    partial class CreateBookish
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.1.22076.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AuthorDbModelBookDbModel", b =>
                {
                    b.Property<int>("AuthorsId")
                        .HasColumnType("int");

                    b.Property<string>("BooksIsbn")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AuthorsId", "BooksIsbn");

                    b.HasIndex("BooksIsbn");

                    b.ToTable("AuthorDbModelBookDbModel");
                });

            modelBuilder.Entity("Bookish.Models.Database.AuthorDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Bookish.Models.Database.BookDbModel", b =>
                {
                    b.Property<string>("Isbn")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookCoverUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Isbn");

                    b.ToTable("BookList");
                });

            modelBuilder.Entity("Bookish.Models.Database.LoanDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BooksIsbn")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CheckedOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DueBack")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MembersId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReturnedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BooksIsbn");

                    b.HasIndex("MembersId");

                    b.ToTable("OnLoan");
                });

            modelBuilder.Entity("Bookish.Models.Database.MemberDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("AuthorDbModelBookDbModel", b =>
                {
                    b.HasOne("Bookish.Models.Database.AuthorDbModel", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookish.Models.Database.BookDbModel", null)
                        .WithMany()
                        .HasForeignKey("BooksIsbn")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bookish.Models.Database.LoanDbModel", b =>
                {
                    b.HasOne("Bookish.Models.Database.BookDbModel", "Books")
                        .WithMany()
                        .HasForeignKey("BooksIsbn");

                    b.HasOne("Bookish.Models.Database.MemberDbModel", "Members")
                        .WithMany()
                        .HasForeignKey("MembersId");

                    b.Navigation("Books");

                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
