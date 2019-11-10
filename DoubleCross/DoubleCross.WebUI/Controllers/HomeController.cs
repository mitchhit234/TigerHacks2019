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
        public ActionResult SubmitIndex(HomeIndexViewModel model)
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
            //TwilioConnectionService.Program.Main(PlayerList, PhoneNumList);

            return RedirectToAction("FirstGame");
        }

        public ActionResult FirstGame()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitFirstGame()
        {
            return RedirectToAction("SecondGame");
        }

        public ActionResult SecondGame()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitSecondGame()
        {
            return RedirectToAction("ThirdGame");
        }
        public ActionResult ThirdGame()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitThirdGame()
        {
            return RedirectToAction("FourthGame");
        }

        public ActionResult FourthGame()
        {
            return View();
        }
        public ActionResult SubmitFourthGame()
        {
            return RedirectToAction("Index");
        }

        public ActionResult HowToPlay()
        {
            return View();
        }
    }
}