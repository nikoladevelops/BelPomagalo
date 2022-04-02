﻿// <auto-generated />
using System;
using BelPomagalo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BelPomagalo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220401082241_AddedAuthorsTable")]
    partial class AddedAuthorsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("BelPomagalo.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BornDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("BornLocation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });
#pragma warning restore 612, 618
        }
    }
}