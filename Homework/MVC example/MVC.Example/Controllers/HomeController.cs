using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Example.Models;

namespace MVC.Example.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<Car> cars = new List<Car>()
            {
                new Car(){ Id = 1, Name = "BMW"},
                new Car(){ Id = 2, Name = "Audi"},
                new Car(){ Id = 3, Name = "BMW"},
                new Car(){ Id = 4, Name = "Audi"},
                new Car(){ Id = 5, Name = "BMW"},
                new Car(){ Id = 6, Name = "Audi"}
            };



            return View(cars);
        }

    }
}
