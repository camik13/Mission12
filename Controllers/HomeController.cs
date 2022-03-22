using LaytonTemple.Models;
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

        //Add appointment
        [HttpGet]
        public IActionResult AddAppointment(Appointment app)
        {
            //Project p = repo.Projects.FirstOrDefault(x => x.ProjectId == projectId);

            //app = Context.Appointments.Where(x => x.AppointmentID == app.AppointmentID);

            return View(app);
        }


        // ADD inputs to database
        [HttpPost]
        public IActionResult AddAppointment(Appointment app, string time)
        {
            app.AppointmentTime = time;

            if (ModelState.IsValid)
            {
                Context.Add(app);
                //Context.Add(app.AppointmentTime = time);
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
                //.OrderBy(x => x.Date) // we do not have a date item in our database yet
                .ToList();
            return View(appointments);
        }


        //Edit Appointment Action
        public IActionResult Edit()
        {
            // TO DO: return View Appointments
            return View();
        }

        [HttpGet]
        public IActionResult AppointmentSelection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AppointmentSelection(string time)
        {

            //Context.Update(Appointment.AppointmentTime = time);
            //Project p = repo.Projects.FirstOrDefault(x => x.ProjectId == projectId);

            //Appointment a = Context.Appointments.Add(x => x.AppointmentTime = time);
            //(x => x.AppointmentTime = time);
            //return RedirectToPage("/AddAppointment", time);

            Appointment app = new Appointment();
            app.AppointmentTime = time;
            //Context.Add(app);

            return View("AddAppointment", app);
        }


        //Delete Appointment Action
        [HttpGet]
        public IActionResult Delete(int appointmentId)
        {
            var app = Context.Appointments.Single(x => x.AppointmentID == appointmentId);

            return View(app);
        }

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
