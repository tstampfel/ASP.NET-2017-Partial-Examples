using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class FirstViewController : Controller
    {
        // GET: FirstView
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyFirstView()

        { 




            ViewBag.MyTitle = "Hello from my View Bag!";

            return View();
        }
    }
}