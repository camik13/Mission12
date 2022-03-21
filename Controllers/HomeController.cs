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

        //Delete Appointment Action
        [HttpGet]
        public IActionResult Delete(int appointmentId)
        {
            var task = Context.Responses.Single(x => x.AppointmentID == appointmentId);

            return View(task);
        }

        [HttpGet]
        public IActionResult AppointmentSelection()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Delete(Appointment appointment)
        {
            Context.Responses.Remove(appointment);
            Context.SaveChanges();

            return RedirectToAction("ViewAppointments"); // Redirects user back to view task page

        }
    }
}
