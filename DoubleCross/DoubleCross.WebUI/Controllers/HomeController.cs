using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DoubleCross.Core.ViewModels;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Submit(HomeIndexViewModel model)
        {
            string playerNames = model.PlayerName;
            string phoneNumbers = model.PhoneNumber;

            List<string> PlayerList = playerNames.Split(',').ToList();
            List<string> PhoneNumList = phoneNumbers.Split(',').ToList();

            if(PlayerList.Count != PhoneNumList.Count)
            {
                // TODO: Find way to implement error message
                return View();
            }
            for (int i = 0; i < PhoneNumList.Count(); i++) {
                PhoneNumList[i] = PhoneNumList[i].Replace("-", "");
            }


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