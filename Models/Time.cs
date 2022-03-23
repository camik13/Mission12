using System;
using System.ComponentModel.DataAnnotations;

namespace LaytonTemple.Models
{
    public class Time
    {
        [Key]
        [Required(ErrorMessage = "Enter a valid Time ID")]
        public int TimeID { get; set; }

        // Should these be required?
        [Required(ErrorMessage = "Enter a valid Time Description")]
        public DateTime TimeDescription { get; set; }

        [Required(ErrorMessage = "Enter a valid slot filled")]
        public bool SlotFilled { get; set; }

    }
}
