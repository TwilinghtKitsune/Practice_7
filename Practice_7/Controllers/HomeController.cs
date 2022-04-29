using Practice_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice_7.Controllers
{
    public class HomeController : Controller
    {
        GuestsContext db = new GuestsContext();
        Guests g = new Guests();
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form(GuestResponse guest)
        {
            if (ModelState.IsValid)
            {
                g.Name = guest.Name;
                g.Email = guest.Email;
                g.Phone = guest.Phone;
                if (guest.WillAttend == true)
                    g.WillAttend = true;
                else g.WillAttend = false;
                db.Guests.Add(g);
                db.SaveChanges();
                return View("Thanks", guest);
            }
            else
                return View();
        }
        [HttpGet]
        public ActionResult AllGuests()
        {
            return View("AllGuests", db.Guests);
        }
    }
}