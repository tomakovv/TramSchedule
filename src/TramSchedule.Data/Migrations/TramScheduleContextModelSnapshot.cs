﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TramSchedule.Data.Context;

#nullable disable

namespace TramSchedule.Data.Migrations
{
    [DbContext(typeof(TramScheduleContext))]
    partial class TramScheduleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TramLineTramStop", b =>
                {
                    b.Property<int>("LinesTramLineId")
                        .HasColumnType("int");

                    b.Property<int>("StopsTramStopId")
                        .HasColumnType("int");

                    b.HasKey("LinesTramLineId", "StopsTramStopId");

                    b.HasIndex("StopsTramStopId");

                    b.ToTable("TramLineTramStop");
                });

            modelBuilder.Entity("TramSchedule.Data.Entities.DepartureTime", b =>
                {
                    b.Property<int>("DepartureTimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartureTimeId"), 1L, 1);

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time");

                    b.Property<int?>("TramDeparturesTramDepartureID")
                        .HasColumnType("int");

                    b.HasKey("DepartureTimeId");

                    b.HasIndex("TramDeparturesTramDepartureID");

                    b.ToTable("DepartureTimes");
                });

            modelBuilder.Entity("TramSchedule.Data.Entities.Tram", b =>
                {
                    b.Property<int>("TramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TramId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("TramId");

                    b.ToTable("Trams");

                    b.HasData(
                        new
                        {
                            TramId = 1,
                            Description = "modern tram",
                            Name = "tramicus",
                            Number = 110
                        },
                        new
                        {
                            TramId = 2,
                            Description = "modern tram",
                            Name = "kiosk",
                            Number = 110
                        },
                        new
                        {
                            TramId = 3,
                            Description = "modern tram",
                            Name = "delfin",
                            Number = 110
                        });
                });

            modelBuilder.Entity("TramSchedule.Data.Entities.TramDepartures", b =>
                {
                    b.Property<int>("TramDepartureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TramDepartureID"), 1L, 1);

                    b.Property<int>("StopTramStopId")
                        .HasColumnType("int");

                    b.Property<int>("TramId")
                        .HasColumnType("int");

                    b.HasKey("TramDepartureID");

                    b.HasIndex("StopTramStopId");

                    b.HasIndex("TramId");

                    b.ToTable("TramDepartures");
                });

            modelBuilder.Entity("TramSchedule.Data.Entities.TramLine", b =>
                {
                    b.Property<int>("TramLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TramLineId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TramLineNumber")
                        .HasColumnType("int");

                    b.HasKey("TramLineId");

                    b.ToTable("TramLines");
                });

            modelBuilder.Entity("TramSchedule.Data.Entities.TramStop", b =>
                {
                    b.Property<int>("TramStopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TramStopId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("TramStopId");

                    b.ToTable("TramStops");
                });

            modelBuilder.Entity("TramSchedule.Data.Entities.TramStopComment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TramStopId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("TramStopId");

                    b.ToTable("TramStopsComments");
                });

            modelBuilder.Entity("TramLineTramStop", b =>
                {
                    b.HasOne("TramSchedule.Data.Entities.TramLine", null)
                        .WithMany()
                        .HasForeignKey("LinesTramLineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TramSchedule.Data.Entities.TramStop", null)
                        .WithMany()
                        .HasForeignKey("StopsTramStopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TramSchedule.Data.Entities.DepartureTime", b =>
                {
                    b.HasOne("TramSchedule.Data.Entities.TramDepartures", null)
                        .WithMany("DepartureTimes")
                        .HasForeignKey("TramDeparturesTramDepartureID");
                });

            modelBuilder.Entity("TramSchedule.Data.Entities.TramDepartures", b =>
                {
                    b.HasOne("TramSchedule.Data.Entities.TramStop", "Stop")
                        .WithMany("Departures")
                        .HasForeignKey("StopTramStopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TramSchedule.Data.Entities.Tram", "Tram")
                        .WithMany("Departures")
                        .HasForeignKey("TramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stop");

                    b.Navigation("Tram");
                });

            modelBuilder.Entity("TramSchedule.Data.Entities.TramStopComment", b =>
                {
                    b.HasOne("TramSchedule.Data.Entities.TramStop", "TramStop")
                        .WithMany("Comments")
                        .HasForeignKey("TramStopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TramStop");
                });

            modelBuilder.Entity("TramSchedule.Data.Entities.Tram", b =>
                {
                    b.Navigation("Departures");
                });

            modelBuilder.Entity("TramSchedule.Data.Entities.TramDepartures", b =>
                {
                    b.Navigation("DepartureTimes");
                });

            modelBuilder.Entity("TramSchedule.Data.Entities.TramStop", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Departures");
                });
#pragma warning restore 612, 618
        }
    }
}
