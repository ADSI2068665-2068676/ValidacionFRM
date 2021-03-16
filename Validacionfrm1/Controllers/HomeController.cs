using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Validacionfrm1.Models;

namespace Validacionfrm1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index2()
        {
            Persona per = new Persona();
            return View(per);
        }
        [HttpPost]
        public ActionResult Index2(Persona per)
        {
            if (ModelState.IsValid)
                return View("Correcto");
            else
                return View(per);
        }
    }
}