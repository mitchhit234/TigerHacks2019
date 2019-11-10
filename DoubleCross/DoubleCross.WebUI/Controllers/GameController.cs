using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{   
    public class GameController : Controller
    {
        [HttpPost]
        public ActionResult FirstGame()
        {
            ViewBag.Message = "Gamer Time";
            return RedirectToAction("ThirdGame", "GameController");
        }
        [HttpPost]
        public ActionResult SecondGame()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThirdGame()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FourthGame()
        {
            return View();
        }
    }
}