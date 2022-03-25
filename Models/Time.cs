using System;
using System.ComponentModel.DataAnnotations;

namespace LaytonTemple.Models
{
    public class Time
    {
        [Key]
        [Required]
        public int TimeID { get; set; }

        public DateTime TimeDescription { get; set; }

        public bool SlotFilled { get; set; }

    }
}
