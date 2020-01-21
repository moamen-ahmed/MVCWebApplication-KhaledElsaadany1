using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebApplication_KhaledElsaadany1.Models;

namespace MVCWebApplication_KhaledElsaadany1.Controllers
{
    public class ComputerController : Controller
    {
        //Create Action Result for Display Computer 

        public ActionResult Display()
        {
            var myComputer = new Computer { 
            Name="Lenovo ThinkPad",
            Price=500
            };
            return View(myComputer);
        }
    }
}