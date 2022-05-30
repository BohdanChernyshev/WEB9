using System;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message =
                "Привет из контроллера DerivedController метода действия Index";
            return View("MyView");
        }
    }
}