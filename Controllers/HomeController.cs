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
            return View();

        }


        // ADD inputs to database from add appointment form 
        [HttpPost]
        public IActionResult AddAppointment(Appointment app)
        {
            //app.AppointmentTime = time;

            if (ModelState.IsValid)
            {
                Context.Add(app);

                //Context.Add(app.AppointmentTime = timeID);

                Context.SaveChanges();

                return View("Index", app); // MAYBE INCLUDE TIME IN HERE TOO ???
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


        // Go to Edit Appointment Form 
        [HttpGet]
        public IActionResult Edit(int appointmentid)
        {
            // TO DO: return View Appointments
            var appt = Context.Appointments.Single(x => x.AppointmentID == appointmentid);
            return RedirectToAction("AddAppointment", appt); // Redirects user back to the form
        }

        // Submit Edit Appointment Form  
        [HttpPost]
        public IActionResult Edit(Appointment appt)
        {
            Context.Update(appt);
            Context.SaveChanges();

            return RedirectToAction("ViewAppointments"); // Redirects user back to view appointment page
        }


        [HttpGet]
        public IActionResult AppointmentSelection()
        {
            var times = Context.Times.ToList();

            return View(times);
        }


        [HttpGet]
        public IActionResult Test(int timeID) // I THINK THIS SHOULD BE AN INT
        {

            //Context.Update(Appointment.AppointmentTime = time);
            //Project p = repo.Projects.FirstOrDefault(x => x.ProjectId == projectId);

            //Appointment a = Context.Appointments.Add(x => x.AppointmentTime = time);
            //(x => x.AppointmentTime = time);
            //return RedirectToPage("/AddAppointment", time);

            //Appointment app = new Appointment();
            //app.AppointmentTime = time;
            //Context.Add(app);

            // should I pass in time right here???
            return View("AddAppointment", timeID);
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
