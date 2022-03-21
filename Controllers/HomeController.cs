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

        public IActionResult Index()
        {
            return View();
        }

        //Add appointment
        [HttpGet]
        public IActionResult AddAppointment()
        {
            return View();
        }

        // ADD inputs to database
        [HttpPost]
        public IActionResult AddAppointment(Appointment app)
        {
            if (ModelState.IsValid)
            {
                Context.Add(app);
                Context.SaveChanges();

                return View("index");
            }
            else
            {
                return View("index");
            }
        }

        [HttpGet]
        public IActionResult ViewAppointments()
        {
            // var app = context.Responses.ToList();
            return View(); // TODO: load the app as a parameter
        }

        //Edit Appointment Action
        public IActionResult Edit()
        {
            // TODO: return View Appointments
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
            //Project p = repo.Projects.FirstOrDefault(x => x.ProjectId == projectId);

            //Appointment a = Context.Appointments.Add(x => x.AppointmentTime = time);
            //(x => x.AppointmentTime = time);

            return View();
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
    }
}
