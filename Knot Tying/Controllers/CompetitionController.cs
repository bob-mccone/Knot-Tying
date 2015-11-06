using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Knot_Tying.Models;

namespace Knot_Tying.Controllers
{
    public class CompetitionController : Controller
    {
        // GET: Competition
        public ActionResult Index() //this is to do with the index view, it will return the form to enter data along with the question
        {
            var model = new CompetitionViewModel();
            return View(model);
        }

        // POST: /SEC/
        [HttpPost]
        public ActionResult Index(CompetitionViewModel model) //this will run when you hit the button on the index page
        {
            if (ModelState.IsValid)
            {
                // BUILD COMPETITION ENTRY HERE!!
                // Using the model - see code there.
                model.SaveEntry(); //this will save the data that has been entered in the text fields into the database

                return View("Thankyou", model); //this will return the thank you page once it has all been saved
            }
            return View(model);
        }

        public JsonResult AutocompleteSuggestions(string searchString) //this is the auto complete that will work on the fields
        {
            var model = new CompetitionViewModel();

            var suggestions = model.GetSuggestion(searchString);

            return Json(suggestions, JsonRequestBehavior.AllowGet);
        }
    }
}