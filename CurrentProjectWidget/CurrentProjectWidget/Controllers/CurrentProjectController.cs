using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CurrentProjectWidget.Controllers
{
    public class CurrentProjectController : Controller
    {
        public ActionResult CurrentProject()
        {
            return Json(new {value = "Hello from MVC Controller"});
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
