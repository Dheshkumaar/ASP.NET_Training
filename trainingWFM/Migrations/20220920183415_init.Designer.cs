﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using trainingWFM.Models;

namespace trainingWFM.Migrations
{
    [DbContext(typeof(WFMdbContext))]
    [Migration("20220920183415_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("trainingWFM.Models.Employees", b =>
                {
                    b.Property<int>("employee_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("employee_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("experience")
                        .HasColumnType("decimal(5,0)");

                    b.Property<string>("lockstatus")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("manager")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("wfm_manager")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("employee_id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("trainingWFM.Models.Skillmaps", b =>
                {
                    b.Property<int>("employee_id")
                        .HasColumnType("int");

                    b.Property<int>("skillid")
                        .HasColumnType("int");

                    b.HasKey("employee_id", "skillid");

                    b.HasIndex("skillid");

                    b.ToTable("Skillmaps");
                });

            modelBuilder.Entity("trainingWFM.Models.Skills", b =>
                {
                    b.Property<int>("skillid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("skillname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("skillid");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("trainingWFM.Models.Skillmaps", b =>
                {
                    b.HasOne("trainingWFM.Models.Employees", "employees")
                        .WithMany("skillmaps")
                        .HasForeignKey("employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("trainingWFM.Models.Skills", "skills")
                        .WithMany("skillmaps")
                        .HasForeignKey("skillid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employees");

                    b.Navigation("skills");
                });

            modelBuilder.Entity("trainingWFM.Models.Employees", b =>
                {
                    b.Navigation("skillmaps");
                });

            modelBuilder.Entity("trainingWFM.Models.Skills", b =>
                {
                    b.Navigation("skillmaps");
                });
#pragma warning restore 612, 618
        }
    }
}
