using System;
using System.ComponentModel.DataAnnotations;

namespace LaytonTemple.Models
{
    public class Time
    {
        //TimeID

        //Datetime object
        //    .tostring method

        //SlotFilled 

        //seed all times that are available

        //may need to use a view model to pass in both models!!!!

        [Key]
        [Required]
        public int TimeID { get; set; }

        [Required]
        public DateTime TimeDescription { get; set; }

        [Required]
        public bool SlotFilled { get; set; }

    }
}
