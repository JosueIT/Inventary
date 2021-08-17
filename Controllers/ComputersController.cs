using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using System.Data;

namespace INVQTM.Controllers
{
    public class ComputersController : Controller
    {
        public IActionResult Index(string serial)
        {
            return PartialView();
        }

        public IActionResult List()
        {
            return PartialView();
        }

        public ActionResult AddForm()
        {
            return RedirectToAction("AddForm", "Home");
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult AssingForm(int id)
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Assing()
        {
            return View();
        }

        public ActionResult Search(string serial)
        {
            return PartialView();
        }

        public ActionResult Filter(int estado)
        {
            return PartialView();
        }


        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
