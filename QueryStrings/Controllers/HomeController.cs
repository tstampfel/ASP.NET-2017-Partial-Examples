using QueryStrings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QueryStrings.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Search(string searchTerm)
        {
            Cars cars = new Cars();
            var model = cars.ReturnCars().Where(x => x.Name.StartsWith(searchTerm)).ToList();
            return View(model);
        }
    }
}