// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TramSchedule.Data.Context;

#nullable disable

namespace TramSchedule.Data.Migrations
{
    [DbContext(typeof(TramScheduleContext))]
    [Migration("20220613162040_Inital")]
    partial class Inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.Property<int?>("TramLineId")
                        .HasColumnType("int");

                    b.HasKey("TramStopId");

                    b.HasIndex("TramLineId");

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

            modelBuilder.Entity("TramSchedule.Data.Entities.TramStop", b =>
                {
                    b.HasOne("TramSchedule.Data.Entities.TramLine", null)
                        .WithMany("Stops")
                        .HasForeignKey("TramLineId");
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

            modelBuilder.Entity("TramSchedule.Data.Entities.TramLine", b =>
                {
                    b.Navigation("Stops");
                });

            modelBuilder.Entity("TramSchedule.Data.Entities.TramStop", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
