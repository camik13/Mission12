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
                    new Time { TimeID = 1, TimeDescription = new DateTime(2022, 03, 28, 8, 00, 0), SlotFilled = false },
                    new Time { TimeID = 2, TimeDescription = new DateTime(2022, 03, 28, 9, 00, 0), SlotFilled = false },
                    new Time { TimeID = 3, TimeDescription = new DateTime(2022, 03, 28, 10, 00, 0), SlotFilled = false },
                    new Time { TimeID = 4, TimeDescription = new DateTime(2022, 03, 28, 11, 00, 0), SlotFilled = false },
                    new Time { TimeID = 5, TimeDescription = new DateTime(2022, 03, 28, 12, 00, 0), SlotFilled = false },
                    new Time { TimeID = 6, TimeDescription = new DateTime(2022, 03, 28, 13, 00, 0), SlotFilled = false },
                    new Time { TimeID = 7, TimeDescription = new DateTime(2022, 03, 28, 14, 00, 0), SlotFilled = false },
                    new Time { TimeID = 8, TimeDescription = new DateTime(2022, 03, 28, 15, 00, 0), SlotFilled = false },
                    new Time { TimeID = 9, TimeDescription = new DateTime(2022, 03, 28, 16, 00, 0), SlotFilled = false },
                    new Time { TimeID = 10, TimeDescription = new DateTime(2022, 03, 28, 17, 00, 0), SlotFilled = false },
                    new Time { TimeID = 11, TimeDescription = new DateTime(2022, 03, 28, 18, 00, 0), SlotFilled = false },
                    new Time { TimeID = 12, TimeDescription = new DateTime(2022, 03, 28, 19, 00, 0), SlotFilled = false },
                    new Time { TimeID = 13, TimeDescription = new DateTime(2022, 03, 28, 20, 00, 0), SlotFilled = false }
                );


        mb.Entity<Appointment>().HasData(
                new Appointment
                {
                    AppointmentID = 1,
                    Name = "Johnson",
                    Size = 3,
                    Email = "Johnson@johnson.com",
                    Phone = "1231234567",
                    AppointmentTime = new DateTime(2022, 03, 28, 8, 00, 0),
                },
                new Appointment
                {
                    AppointmentID = 2,
                    Name = "Davidson",
                    Size = 4,
                    Email = "Davidson@davidson.com",
                    Phone = "9879876543",
                    AppointmentTime = new DateTime(2022, 03, 28, 10, 00, 0),
                },
                new Appointment
                {
                    AppointmentID = 3,
                    Name = "Jackson",
                    Size = 2,
                    Email = "Jackson@jackson.com",
                    Phone = "5555555555",
                    AppointmentTime = new DateTime(2022, 03, 28, 12, 00, 0),
                });
        }
    }
}
