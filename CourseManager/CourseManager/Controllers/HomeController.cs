using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseManager.Models;
using CourseManager.Filters;
namespace CourseManager.Controllers
{
    [RequireAuthentication]
    [ActionResultExceptionFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "你的应用程序说明页。";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "你的联系方式页。";

            return View();
        }
        [ChildActionOnly]
        public ActionResult Navbar()
        {
            var site = new WebsiteInfo();
            ViewBag.Site = site;
            return PartialView("~/Views/Shared/Navbar.cshtm");
        }
    }
}
