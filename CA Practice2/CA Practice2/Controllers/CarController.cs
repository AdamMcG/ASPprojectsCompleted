using CA_Practice2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA_Practice2.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        [HttpGet]
      public ActionResult CarPurchase()
        { return View(); }

        public ActionResult CarPurchase(Car carp)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirm", carp);
            }
            else
            {
                return View(carp);
            }
        }

        public ActionResult Confirm(Car carp)
        {
            return View(carp);
        }
    }
}