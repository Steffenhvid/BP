﻿// <auto-generated />
using System;
using BP.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BP.Infrastructure.Migrations
{
    [DbContext(typeof(BPContext))]
    [Migration("20230621142733_tet")]
    partial class tet
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BP.Infrastructure.Entities.DeveloperEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("DeveloperId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

                    b.ToTable("DeveloperEntities");
                });

            modelBuilder.Entity("BP.Infrastructure.Entities.SkillEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("DeveloperEntityId")
                        .HasColumnType("integer");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperEntityId");

                    b.ToTable("SkillEntities");
                });

            modelBuilder.Entity("BP.Infrastructure.Entities.DeveloperEntity", b =>
                {
                    b.HasOne("BP.Infrastructure.Entities.SkillEntity", null)
                        .WithMany()
                        .HasForeignKey("DeveloperId");
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
