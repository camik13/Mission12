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
        [Required]
        public int AppointmentID { get; set; }
        [Required(ErrorMessage = "Please enter a Group Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter an Amount of Guests")]
        public int Size { get; set; }
        [Required(ErrorMessage = "Please enter an Email")]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required]
        public string AppointmentTime { get; set; }
    }
}
