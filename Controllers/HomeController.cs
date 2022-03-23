using LaytonTemple.Models;
using LaytonTemple.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult AddAppointment(int timeID)
        {
            //return View(app);
            return View(new AppViewModel
            {
                time = Context.Times.Single(t => t.TimeID == timeID)
            });

        }


        // ADD inputs to database from add appointment form 
        [HttpPost]
        public IActionResult AddAppointment(AppViewModel a, int timeID)
        {

            if (ModelState.IsValid)
            {
                Context.Times.Single(t => t.TimeID == timeID).SlotFilled = true;
                Context.Appointments.Add(a.app);

                Context.SaveChanges(); // error here

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


        //[HttpGet]
        //public IActionResult Test(int timeID) // I THINK THIS SHOULD BE AN INT
        //{
        //    //ViewBag.Time = timeID;
        //    //ViewBag.Time = Context.Times
        //    //    .Where(x => x.TimeID == timeID);

        //    ViewBag.Time = Context.Times.Single(x => x.TimeID == timeID); 

        //    //return View("AddAppointment", timeID);
        //    return View("AddAppointment", timeID);
        //}


        // Go to Edit Appointment Form 
        [HttpGet]
        public IActionResult Edit(int appointmentid)
        {
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
