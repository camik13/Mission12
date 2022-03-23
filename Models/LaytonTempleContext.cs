using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTemple.Models
{
    public class LaytonTempleContext : DbContext
    {
        public LaytonTempleContext()
        {

        }

        public LaytonTempleContext(DbContextOptions<LaytonTempleContext> options)
            : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Time> Times { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Time>().HasData(
                    // MONDAY 
                    new Time { TimeID = 1, TimeDescription = new DateTime(2022, 03, 28, 8, 00, 0), SlotFilled = true },
                    new Time { TimeID = 2, TimeDescription = new DateTime(2022, 03, 28, 9, 00, 0), SlotFilled = true },
                    new Time { TimeID = 3, TimeDescription = new DateTime(2022, 03, 28, 10, 00, 0), SlotFilled = true },
                    new Time { TimeID = 4, TimeDescription = new DateTime(2022, 03, 28, 11, 00, 0), SlotFilled = false },
                    new Time { TimeID = 5, TimeDescription = new DateTime(2022, 03, 28, 12, 00, 0), SlotFilled = false },
                    new Time { TimeID = 6, TimeDescription = new DateTime(2022, 03, 28, 13, 00, 0), SlotFilled = false },
                    new Time { TimeID = 7, TimeDescription = new DateTime(2022, 03, 28, 14, 00, 0), SlotFilled = false },
                    new Time { TimeID = 8, TimeDescription = new DateTime(2022, 03, 28, 15, 00, 0), SlotFilled = false },
                    new Time { TimeID = 9, TimeDescription = new DateTime(2022, 03, 28, 16, 00, 0), SlotFilled = false },
                    new Time { TimeID = 10, TimeDescription = new DateTime(2022, 03, 28, 17, 00, 0), SlotFilled = false },
                    new Time { TimeID = 11, TimeDescription = new DateTime(2022, 03, 28, 18, 00, 0), SlotFilled = false },
                    new Time { TimeID = 12, TimeDescription = new DateTime(2022, 03, 28, 19, 00, 0), SlotFilled = false },
                    new Time { TimeID = 13, TimeDescription = new DateTime(2022, 03, 28, 20, 00, 0), SlotFilled = false },

                    // TUESDAY 
                    new Time { TimeID = 14, TimeDescription = new DateTime(2022, 03, 29, 8, 00, 0), SlotFilled = false },
                    new Time { TimeID = 15, TimeDescription = new DateTime(2022, 03, 29, 9, 00, 0), SlotFilled = false },
                    new Time { TimeID = 16, TimeDescription = new DateTime(2022, 03, 29, 10, 00, 0), SlotFilled = false },
                    new Time { TimeID = 17, TimeDescription = new DateTime(2022, 03, 29, 11, 00, 0), SlotFilled = false },
                    new Time { TimeID = 18, TimeDescription = new DateTime(2022, 03, 29, 12, 00, 0), SlotFilled = false },
                    new Time { TimeID = 19, TimeDescription = new DateTime(2022, 03, 29, 13, 00, 0), SlotFilled = false },
                    new Time { TimeID = 20, TimeDescription = new DateTime(2022, 03, 29, 14, 00, 0), SlotFilled = false },
                    new Time { TimeID = 21, TimeDescription = new DateTime(2022, 03, 29, 15, 00, 0), SlotFilled = false },
                    new Time { TimeID = 22, TimeDescription = new DateTime(2022, 03, 29, 16, 00, 0), SlotFilled = false },
                    new Time { TimeID = 23, TimeDescription = new DateTime(2022, 03, 29, 17, 00, 0), SlotFilled = false },
                    new Time { TimeID = 24, TimeDescription = new DateTime(2022, 03, 29, 18, 00, 0), SlotFilled = false },
                    new Time { TimeID = 25, TimeDescription = new DateTime(2022, 03, 29, 19, 00, 0), SlotFilled = false },
                    new Time { TimeID = 26, TimeDescription = new DateTime(2022, 03, 29, 20, 00, 0), SlotFilled = false },

                    // WEDNESDAY
                    new Time { TimeID = 27, TimeDescription = new DateTime(2022, 03, 30, 8, 00, 0), SlotFilled = false },
                    new Time { TimeID = 28, TimeDescription = new DateTime(2022, 03, 30, 9, 00, 0), SlotFilled = false },
                    new Time { TimeID = 29, TimeDescription = new DateTime(2022, 03, 30, 10, 00, 0), SlotFilled = false },
                    new Time { TimeID = 30, TimeDescription = new DateTime(2022, 03, 30, 11, 00, 0), SlotFilled = false },
                    new Time { TimeID = 31, TimeDescription = new DateTime(2022, 03, 30, 12, 00, 0), SlotFilled = false },
                    new Time { TimeID = 32, TimeDescription = new DateTime(2022, 03, 30, 13, 00, 0), SlotFilled = false },
                    new Time { TimeID = 33, TimeDescription = new DateTime(2022, 03, 30, 14, 00, 0), SlotFilled = false },
                    new Time { TimeID = 34, TimeDescription = new DateTime(2022, 03, 30, 15, 00, 0), SlotFilled = false },
                    new Time { TimeID = 35, TimeDescription = new DateTime(2022, 03, 30, 16, 00, 0), SlotFilled = false },
                    new Time { TimeID = 36, TimeDescription = new DateTime(2022, 03, 30, 17, 00, 0), SlotFilled = false },
                    new Time { TimeID = 37, TimeDescription = new DateTime(2022, 03, 30, 18, 00, 0), SlotFilled = false },
                    new Time { TimeID = 38, TimeDescription = new DateTime(2022, 03, 30, 19, 00, 0), SlotFilled = false },
                    new Time { TimeID = 39, TimeDescription = new DateTime(2022, 03, 30, 20, 00, 0), SlotFilled = false },

                    // THURSDAY
                    new Time { TimeID = 40, TimeDescription = new DateTime(2022, 03, 31, 8, 00, 0), SlotFilled = false },
                    new Time { TimeID = 41, TimeDescription = new DateTime(2022, 03, 31, 9, 00, 0), SlotFilled = false },
                    new Time { TimeID = 42, TimeDescription = new DateTime(2022, 03, 31, 10, 00, 0), SlotFilled = false },
                    new Time { TimeID = 43, TimeDescription = new DateTime(2022, 03, 31, 11, 00, 0), SlotFilled = false },
                    new Time { TimeID = 44, TimeDescription = new DateTime(2022, 03, 31, 12, 00, 0), SlotFilled = false },
                    new Time { TimeID = 45, TimeDescription = new DateTime(2022, 03, 31, 13, 00, 0), SlotFilled = false },
                    new Time { TimeID = 46, TimeDescription = new DateTime(2022, 03, 31, 14, 00, 0), SlotFilled = false },
                    new Time { TimeID = 47, TimeDescription = new DateTime(2022, 03, 31, 15, 00, 0), SlotFilled = false },
                    new Time { TimeID = 48, TimeDescription = new DateTime(2022, 03, 31, 16, 00, 0), SlotFilled = false },
                    new Time { TimeID = 49, TimeDescription = new DateTime(2022, 03, 31, 17, 00, 0), SlotFilled = false },
                    new Time { TimeID = 50, TimeDescription = new DateTime(2022, 03, 31, 18, 00, 0), SlotFilled = false },
                    new Time { TimeID = 51, TimeDescription = new DateTime(2022, 03, 31, 19, 00, 0), SlotFilled = false },
                    new Time { TimeID = 52, TimeDescription = new DateTime(2022, 03, 31, 20, 00, 0), SlotFilled = false },

                    // FRIDAY
                    new Time { TimeID = 53, TimeDescription = new DateTime(2022, 04, 01, 8, 00, 0), SlotFilled = false },
                    new Time { TimeID = 54, TimeDescription = new DateTime(2022, 04, 01, 9, 00, 0), SlotFilled = false },
                    new Time { TimeID = 55, TimeDescription = new DateTime(2022, 04, 01, 10, 00, 0), SlotFilled = false },
                    new Time { TimeID = 56, TimeDescription = new DateTime(2022, 04, 01, 11, 00, 0), SlotFilled = false },
                    new Time { TimeID = 57, TimeDescription = new DateTime(2022, 04, 01, 12, 00, 0), SlotFilled = false },
                    new Time { TimeID = 58, TimeDescription = new DateTime(2022, 04, 01, 13, 00, 0), SlotFilled = false },
                    new Time { TimeID = 59, TimeDescription = new DateTime(2022, 04, 01, 14, 00, 0), SlotFilled = false },
                    new Time { TimeID = 60, TimeDescription = new DateTime(2022, 04, 01, 15, 00, 0), SlotFilled = false },
                    new Time { TimeID = 61, TimeDescription = new DateTime(2022, 04, 01, 16, 00, 0), SlotFilled = false },
                    new Time { TimeID = 62, TimeDescription = new DateTime(2022, 04, 01, 17, 00, 0), SlotFilled = false },
                    new Time { TimeID = 63, TimeDescription = new DateTime(2022, 04, 01, 18, 00, 0), SlotFilled = false },
                    new Time { TimeID = 64, TimeDescription = new DateTime(2022, 04, 01, 19, 00, 0), SlotFilled = false },
                    new Time { TimeID = 65, TimeDescription = new DateTime(2022, 04, 01, 20, 00, 0), SlotFilled = false },

                    // SATURDAY
                    new Time { TimeID = 66, TimeDescription = new DateTime(2022, 04, 02, 8, 00, 0), SlotFilled = false },
                    new Time { TimeID = 67, TimeDescription = new DateTime(2022, 04, 02, 9, 00, 0), SlotFilled = false },
                    new Time { TimeID = 68, TimeDescription = new DateTime(2022, 04, 02, 10, 00, 0), SlotFilled = false },
                    new Time { TimeID = 69, TimeDescription = new DateTime(2022, 04, 02, 11, 00, 0), SlotFilled = false },
                    new Time { TimeID = 70, TimeDescription = new DateTime(2022, 04, 02, 12, 00, 0), SlotFilled = false },
                    new Time { TimeID = 71, TimeDescription = new DateTime(2022, 04, 02, 13, 00, 0), SlotFilled = false },
                    new Time { TimeID = 72, TimeDescription = new DateTime(2022, 04, 02, 14, 00, 0), SlotFilled = false },
                    new Time { TimeID = 73, TimeDescription = new DateTime(2022, 04, 02, 15, 00, 0), SlotFilled = false },
                    new Time { TimeID = 74, TimeDescription = new DateTime(2022, 04, 02, 16, 00, 0), SlotFilled = false },
                    new Time { TimeID = 75, TimeDescription = new DateTime(2022, 04, 02, 17, 00, 0), SlotFilled = false },
                    new Time { TimeID = 76, TimeDescription = new DateTime(2022, 04, 02, 18, 00, 0), SlotFilled = false },
                    new Time { TimeID = 77, TimeDescription = new DateTime(2022, 04, 02, 19, 00, 0), SlotFilled = false },
                    new Time { TimeID = 78, TimeDescription = new DateTime(2022, 04, 02, 20, 00, 0), SlotFilled = false },

                    // SUNDAY
                    new Time { TimeID = 79, TimeDescription = new DateTime(2022, 04, 03, 8, 00, 0), SlotFilled = true },
                    new Time { TimeID = 80, TimeDescription = new DateTime(2022, 04, 03, 9, 00, 0), SlotFilled = true },
                    new Time { TimeID = 81, TimeDescription = new DateTime(2022, 04, 03, 10, 00, 0), SlotFilled = true },
                    new Time { TimeID = 82, TimeDescription = new DateTime(2022, 04, 03, 11, 00, 0), SlotFilled = true },
                    new Time { TimeID = 83, TimeDescription = new DateTime(2022, 04, 03, 12, 00, 0), SlotFilled = true },
                    new Time { TimeID = 84, TimeDescription = new DateTime(2022, 04, 03, 13, 00, 0), SlotFilled = true },
                    new Time { TimeID = 85, TimeDescription = new DateTime(2022, 04, 03, 14, 00, 0), SlotFilled = true },
                    new Time { TimeID = 86, TimeDescription = new DateTime(2022, 04, 03, 15, 00, 0), SlotFilled = true },
                    new Time { TimeID = 87, TimeDescription = new DateTime(2022, 04, 03, 16, 00, 0), SlotFilled = true },
                    new Time { TimeID = 88, TimeDescription = new DateTime(2022, 04, 03, 17, 00, 0), SlotFilled = true },
                    new Time { TimeID = 89, TimeDescription = new DateTime(2022, 04, 03, 18, 00, 0), SlotFilled = true },
                    new Time { TimeID = 90, TimeDescription = new DateTime(2022, 04, 03, 19, 00, 0), SlotFilled = true },
                    new Time { TimeID = 91, TimeDescription = new DateTime(2022, 04, 03, 20, 00, 0), SlotFilled = true }

                );


        mb.Entity<Appointment>().HasData(
                new Appointment
                {
                    AppointmentID = 1,
                    Name = "Johnson",
                    Size = 3,
                    Email = "Johnson@johnson.com",
                    Phone = "1231234567",
                    TimeID = 1,
                },
                new Appointment
                {
                    AppointmentID = 2,
                    Name = "Davidson",
                    Size = 4,
                    Email = "Davidson@davidson.com",
                    Phone = "9879876543",
                    TimeID = 2,
                },
                new Appointment
                {
                    AppointmentID = 3,
                    Name = "Jackson",
                    Size = 2,
                    Email = "Jackson@jackson.com",
                    Phone = "5555555555",
                    TimeID = 3,
                });
        }
    }
}
