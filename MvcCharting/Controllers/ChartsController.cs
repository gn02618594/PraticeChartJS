using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCharting.Controllers
{
    public class ChartsController : Controller
    {
        // GET: Charts
        public ActionResult LineTemperature()
        {
            return View();
        }
    }
}