using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoubleCross.Core.ViewModels;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            _twilioConnectionService = twilioConnectionService;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Submit(HomeIndexViewModel model)
        {
            string playerNames = model.PlayerName;
            
            string phoneNumbers = model.PhoneNumber;

            return View();
        }

        public ActionResult Game()
        {
            ViewBag.Message = "Gamer Time";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}