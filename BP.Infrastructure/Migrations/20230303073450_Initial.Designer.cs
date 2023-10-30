﻿// <auto-generated />
using System;
using BP.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BP.Infrastructure.Migrations
{
    [DbContext(typeof(BPContext))]
    [Migration("20230303073450_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("BP.Infrastructure.Entities.DeveloperEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DeveloperEntities");
                });

            modelBuilder.Entity("BP.Infrastructure.Entities.SkillEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DeveloperEntityId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperEntityId");

                    b.ToTable("SkillEntities");
                });

            modelBuilder.Entity("BP.Infrastructure.Entities.SkillEntity", b =>
                {
                    b.HasOne("BP.Infrastructure.Entities.DeveloperEntity", null)
                        .WithMany("Skills")
                        .HasForeignKey("DeveloperEntityId");
                });

            modelBuilder.Entity("BP.Infrastructure.Entities.DeveloperEntity", b =>
                {
                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
