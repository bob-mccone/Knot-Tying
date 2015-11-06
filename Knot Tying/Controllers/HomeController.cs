using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knot_Tying.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This page covers what this website is about."; //this will display when you write viewbag.message on the about page

            return View();
        }

        public ActionResult History()
        {
            ViewBag.Message = "This is where you will learn about the history of knot tying and when it all started."; //same for this bit but on history page

            return View();
        }

        public ActionResult Tutorials()
        {
            ViewBag.Message = "This is where you are going to learn how to tie knots."; //same again but for the tutorials page

            return View();
        }

        public ActionResult UploadCentre()
        {
            ViewBag.Message = "This is where you upload video of the knot tying you have done."; //same again but for the upload centre page

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Got a problem feel free to contact us... or not."; //same again but for contact page

            return View();
        }
    }
}