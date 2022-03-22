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
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Appointment>().HasData(
                new Appointment
                {
                    AppointmentID = 1,
                    Name = "Johnson",
                    Size = 3,
                    Email = "Johnson@johnson.com",
                    Phone = "1231234567",
                    AppointmentTime = "1:00 PM",
                },
                new Appointment
                {
                    AppointmentID = 2,
                    Name = "Davidson",
                    Size = 4,
                    Email = "Davidson@davidson.com",
                    Phone = "9879876543",
                    AppointmentTime = "11:00 AM",
                },
                new Appointment
                {
                    AppointmentID = 3,
                    Name = "Jackson",
                    Size = 2,
                    Email = "Jackson@jackson.com",
                    Phone = "5555555555",
                    AppointmentTime = "5:00 PM",
                });
        }
    }
}
