// <auto-generated />
using System;
using LaytonTemple.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LaytonTemple.Migrations
{
    [DbContext(typeof(LaytonTempleContext))]
    partial class LaytonTempleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("LaytonTemple.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TimeID")
                        .HasColumnType("INTEGER");

                    b.HasKey("AppointmentID");

                    b.HasIndex("TimeID");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            AppointmentID = 1,
                            Email = "Johnson@johnson.com",
                            Name = "Johnson",
                            Phone = "1231234567",
                            Size = 3,
                            TimeID = 1
                        },
                        new
                        {
                            AppointmentID = 2,
                            Email = "Davidson@davidson.com",
                            Name = "Davidson",
                            Phone = "9879876543",
                            Size = 4,
                            TimeID = 2
                        },
                        new
                        {
                            AppointmentID = 3,
                            Email = "Jackson@jackson.com",
                            Name = "Jackson",
                            Phone = "5555555555",
                            Size = 2,
                            TimeID = 3
                        });
                });

            modelBuilder.Entity("LaytonTemple.Models.Time", b =>
                {
                    b.Property<int>("TimeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SlotFilled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeDescription")
                        .HasColumnType("TEXT");

                    b.HasKey("TimeID");

                    b.ToTable("Times");

                    b.HasData(
                        new
                        {
                            TimeID = 1,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 2,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 3, 28, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 3,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 3, 28, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 4,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 28, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 5,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 6,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 28, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 7,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 8,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 9,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 10,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 28, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 11,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 28, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 12,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 28, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 13,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 28, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 14,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 29, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 15,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 29, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 16,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 29, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 17,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 29, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 18,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 29, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 19,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 29, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 20,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 29, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 21,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 29, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 22,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 23,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 29, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 24,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 29, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 25,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 29, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 26,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 29, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 27,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 28,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 30, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 29,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 30, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 30,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 30, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 31,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 30, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 32,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 30, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 33,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 30, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 34,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 30, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 35,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 36,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 30, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 37,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 30, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 38,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 30, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 39,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 30, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 40,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 31, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 41,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 31, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 42,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 31, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 43,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 31, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 44,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 45,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 31, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 46,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 47,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 48,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 49,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 31, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 50,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 31, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 51,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 31, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 52,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 3, 31, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 53,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 54,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 55,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 56,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 57,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 58,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 1, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 59,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 60,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 61,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 62,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 1, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 63,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 64,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 1, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 65,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 1, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 66,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 67,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 2, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 68,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 2, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 69,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 2, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 70,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 2, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 71,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 2, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 72,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 2, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 73,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 2, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 74,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 75,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 76,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 2, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 77,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 2, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 78,
                            SlotFilled = false,
                            TimeDescription = new DateTime(2022, 4, 2, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 79,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 80,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 4, 3, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 81,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 4, 3, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 82,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 4, 3, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 83,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 4, 3, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 84,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 4, 3, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 85,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 4, 3, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 86,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 4, 3, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 87,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 88,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 4, 3, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 89,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 4, 3, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 90,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 4, 3, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TimeID = 91,
                            SlotFilled = true,
                            TimeDescription = new DateTime(2022, 4, 3, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("LaytonTemple.Models.Appointment", b =>
                {
                    b.HasOne("LaytonTemple.Models.Time", "Time")
                        .WithMany()
                        .HasForeignKey("TimeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
