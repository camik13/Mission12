using LaytonTemple.Models;
using LaytonTemple.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTemple.Controllers
{
    public class HomeController : Controller
    {
        private LaytonTempleContext Context { get; set; }

        //Constructor
        public HomeController(LaytonTempleContext someName)
        {
            Context = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Go to add appointment page
        [HttpGet]
        public IActionResult AddAppointment(int timeId)
        {

            Appointment app = new Appointment
            {
                TimeID = timeId
            };

            ViewBag.TimeDescription = Context.Times.Single(x => x.TimeID == timeId).TimeDescription;

            return View(app);
        }


        // ADD inputs to database from add appointment form 
        [HttpPost]
        public IActionResult AddAppointment(Appointment a)
        {
            if (ModelState.IsValid)
            {
                Context.Update(a);

                Context.SaveChanges();

                return View("Index");
            }
            else
            {
                return View("Index");
            }
        }


        // Page to view appointments in table format
        [HttpGet]
        public IActionResult ViewAppointments()
        {
            var appointments = Context.Appointments
                //.OrderBy(x => x.AppointmentTime) // we do not have a date item in our database yet
                .ToList();
            return View(appointments);
        }


        [HttpGet]
        public IActionResult AppointmentSelection()
        {
            var times = Context.Times.ToList();

            return View(times);
        }


        // Go to Edit Appointment Form 
        [HttpGet]
        public IActionResult Edit(int appointmentid)
        {
            //var blah = Context.Appointments.Include("Times").Single(x => x.AppointmentID == appointmentid).Time.TimeDescription;

            // TO DO: return View Appointments
            var appt = Context.Appointments.Single(x => x.AppointmentID == appointmentid);
            return View("AddAppointment", appt); // Redirects user back to the form
        }

        // Submit Edit Appointment Form  
        [HttpPost]
        public IActionResult Edit(Appointment appt)
        {
            if (ModelState.IsValid)
            {
                Context.Update(appt);
                Context.SaveChanges();
                return Redirect("ViewAppointments"); // Redirects user back to view appointment page
            }
            else //if invalid
            {
                return View("ViewAppointments");
            }
        }


        //Delete Appointment Action
        [HttpGet]
        public IActionResult Delete(int appointmentId)
        {
            var app = Context.Appointments.Single(x => x.AppointmentID == appointmentId);

            return View(app);
        }

        //Submit delete 
        [HttpPost]
        public IActionResult Delete(Appointment appointment)
        {
            Context.Appointments.Remove(appointment);
            Context.SaveChanges();

            return RedirectToAction("ViewAppointments"); // Redirects user back to view appointment page

        }


        //Edit Appointment Action
        //[HttpGet]


    }
}
