﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Socionic.DBContext;

#nullable disable

namespace Socionic.Migrations
{
    [DbContext(typeof(SocionicContext))]
    [Migration("20220330131635_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.1.22076.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Socionic.Models.AnswerOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AnswerOptions");
                });

            modelBuilder.Entity("Socionic.Models.PsychosophyTypes", b =>
                {
                    b.Property<Guid>("PsyTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PsyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PsyTypeId");

                    b.ToTable("PsychosophyTypes");
                });

            modelBuilder.Entity("Socionic.Models.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Socionic.Models.SocionicTypes", b =>
                {
                    b.Property<Guid>("SocTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SocName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SocTypeId");

                    b.ToTable("SocionicTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
