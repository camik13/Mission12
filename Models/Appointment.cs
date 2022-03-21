using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTemple.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required]
        public string AppointmentTime { get; }
    }
}
