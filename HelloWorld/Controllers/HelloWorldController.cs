using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "Hello World!";
        }

        public string Hello()
        {
            return "<h1> Hello from Html! <h1/>";
        }


    }
}