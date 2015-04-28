using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registar.BusinessLayer;
using Registar.BusinessLayer.Contracts;
using Registar.Models;
using Registar.DomainModel;

namespace Registar.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //call BL
            BikeSearchCommand _command = new BikeSearchCommand();
            _command.PageIndex = 0;
            _command.PageSize = 10;

            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(_command);
            //
            return View("Index3", _result.Result);
        }

        public ActionResult Index2()
        {
            List<Bike> _result = new List<Bike>();
            _result.Add(new Bike() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new Bike() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new Bike() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new Bike() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            //
            this.ViewBag.SomeNewProperty = "theValue";
            this.ViewData["SomeNewProperty"] = "theValue";
            //
            return View("Index",_result);
        }

    }
}
