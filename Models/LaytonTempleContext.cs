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
    }
}
