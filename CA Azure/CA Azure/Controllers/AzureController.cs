using CA_Azure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA_Azure.Controllers
{
    public class AzureController : Controller
    {
        // GET: Azure
        [HttpGet]
        public ActionResult Calculate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(AzureCosts costs)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirm", costs);
            }
            else
            {
                return View(costs);
            }
        }

        public ActionResult Confirm(AzureCosts costs)
        {
            return View(costs);
        }
    }
}