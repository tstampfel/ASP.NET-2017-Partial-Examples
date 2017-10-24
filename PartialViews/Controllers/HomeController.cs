using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViews.Controllers
{
    public class Cars
    {
        public string Name { get; set; }
        public int HorsePower { get; set; }
        public int YearofProduction { get; set; }
        public int Speed { get; set; }
        public string ImageUrl { get; set; }




        public Cars(string name, int horsepower, int yearofproduction, int speed, string imageurl)
        {
            Name = name;
            HorsePower = horsepower;
            YearofProduction = yearofproduction;
            Speed = speed;
            ImageUrl = imageurl;




        }

    }

    
    public class HomeController : Controller
    {
        public static List<Cars> getCars()
        {

            List<Cars> carsList = new List<Cars>();

            Cars car1 = new Cars("Audi",300, 1999, 200, "~/Images/audi.jpg");
            Cars car2 = new Cars("Yugo", 80, 1970, 130, "~/Images/yugo.jpg");
            Cars car3 = new Cars("Volvo", 200, 2010, 200, "~/Images/volvo.png");
            Cars car4 = new Cars("Dacia", 150, 2012, 170, "~/Images/dacia.jpg");


            carsList.Add(car1);
            carsList.Add(car2);
            carsList.Add(car3);
            carsList.Add(car4);


            return carsList;

        }



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            ViewData["ListOfCars"] = getCars();


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            ViewData["ListOfCars"] = getCars();

            return View();
        }
    }
}