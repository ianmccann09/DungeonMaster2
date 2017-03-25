using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hangman.Controllers
{
    public class HangManController : Controller
    {
        // GET: HangMan


        public ActionResult PlayGame()
        {

            return View();
        }
        public ActionResult EasyGame()
        {

            return View();
        }
        public ActionResult NormalGame()
        {

            return View();
        }
        public ActionResult HardGame()
        {

            return View();
        }
    }
}