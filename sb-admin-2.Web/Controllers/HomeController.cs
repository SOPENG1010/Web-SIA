using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sb_admin_2.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MissionandVission()
        {
            return View();
        }

        public ActionResult CoreValues()
        {
            return View("CoreValues");
        }

        public ActionResult UniversityCalendar()
        {
            return View("UniversityCalendar");
        }

        public ActionResult UniversityHymn()
        {
            return View("UniversityHymn");
        }

        public ActionResult SanBartolome()
        {
            return View("San Bartolome");
        }

        public ActionResult Batasan()
        {
            return View("Batasan");
        }

        public ActionResult SanFrancisco()
        {
            return View("San Francisco");
        }

        public ActionResult TranscriptOfRecord()
        {
            return View("TranscriptOfRecord");
        }

        public ActionResult DownlableForms()
        {
            return View("Downloadable Forms");
        }

        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult Register()
        {
            return View("Register");
        }

        public ActionResult ForgotPassword()
        {
            return View("ForgotPassword");
        }













    }
}