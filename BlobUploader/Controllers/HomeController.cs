﻿using System.Web.Mvc;

namespace BlobUploader.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello World!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Testing Azure Web Site with the new MVC4 Simple Membership login";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Don't call us, we will call you!";

            return View();
        }
    }
}
