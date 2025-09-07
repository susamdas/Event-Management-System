using Microsoft.AspNetCore.Mvc;
using QuickEventSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickEventSolution.Controllers
{
    public class HomeController : Controller
    {

        
        private static List<Event> Events = new List<Event>
        {
            // Sample events
            new Event { Id = 1, Name="Music Concert", Description="Live Music", Date=DateTime.Parse("2025-08-20"), Address="City Hall, Mirpur-2, Dhaka-1216", AssignedUserId=1 },
            new Event { Id = 2, Name="Tech Talk", Description="Technology Seminar", Date=DateTime.Parse("2025-09-05"), Address="Tech Center, Mirpur-1, Dhaka-1216", AssignedUserId=2 },
            new Event { Id = 3, Name="Art Exhibition", Description="Modern Art", Date=DateTime.Parse("2025-10-01"), Address="Gallery Bhaban, Bijoy Road, Dhaka-1217", AssignedUserId=3 },
            new Event { Id = 4, Name="Food Festival", Description="Culinary Delights", Date=DateTime.Parse("2025-11-15"), Address="Love Road, Mirpur-2, Dhaka-1216", AssignedUserId=4 },
            new Event { Id = 5, Name="Book Fair", Description="Annual Book Fair", Date=DateTime.Parse("2024-12-10"), Address="Convention Center, Mirpur-2, Dhaka-1216", AssignedUserId=2 },
            new Event { Id = 6, Name="Marathon", Description="City Marathon", Date=DateTime.Parse("2024-07-30"), Address="Main Street, Bijoy Sarani, Dhaka-1215", AssignedUserId=3 },
            new Event { Id = 7, Name="Charity Gala", Description="Fundraising Event", Date=DateTime.Parse("2024-09-20"), Address="Grand Hotel, Agargoan, Dhaka-1215", AssignedUserId=1 }
        };

        private static List<User> Users = new List<User>
        {
            new User { Id=1, FirstName="Susam", LastName="Das", ContactNumber="01714496737", Email="sk_das@gmail.com", UserType=1 },
            new User { Id=2, FirstName="Arun", LastName="Krishna", ContactNumber="01762514923", Email="arun_das@gmail.com", UserType=2 },
            new User { Id=3, FirstName="Chayan", LastName="Das", ContactNumber="01748060382", Email="chayan.pstu@gmail.com", UserType=3 },
            new User { Id=4, FirstName="Riya", LastName="Moni", ContactNumber="01784541545", Email="riya.pstu@gmail.com", UserType=4 }
        };

        // Default page → Upcoming Events
        public IActionResult Index()
        {
            return RedirectToAction("UpcomingEvents");
        }

        public IActionResult AllEvents()
        {
            var events = Events.OrderBy(e => e.Date).ToList();
            return View(events);
        }

        public IActionResult UpcomingEvents()
        {
            var today = DateTime.Today;
            var upcoming = Events
                .Where(e => e.Date.Date > today) 
                .OrderBy(e => e.Date)
                .ToList();

            return View(upcoming);
        }


        public IActionResult UsersPage()
        {
            return View("Users", Users);
        }
    }
}
