﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoAPI.Model;

namespace ToDoWebAPI.Migrations
{
    [DbContext(typeof(ToDoDbContext))]
    [Migration("20210420002502_intis")]
    partial class intis
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToDoWebAPI.Model.ToDoItem", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("Responsible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Task")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ToDoItems");
                });
#pragma warning restore 612, 618
        }
    }
}