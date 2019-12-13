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
        private CourseManagerEntities db = new CourseManagerEntities();

        public ActionResult Index()
        {
            var siteInfo = new WebsiteInfo("Demo","RIGHT");

            ViewBag.SiteInfo = siteInfo;

            ViewData["SiteInfo"] = siteInfo;
            
           // if(new Random().Next(2) == 0)
             //   return View("~/Views/Home/View.cshtml");
            //else
              return View(siteInfo);     

           // return View("~/Views/Home/View2.cshtml");
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
    }
}
