using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSummator.Controllers
{
    using MVCSummator.Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult Addition()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Addition(AdditionViewModel model)
        {
            model.Sum = model.FirstNumber + model.SecondNumber;
            return this.View(model);
        }

        public ActionResult About()
        {
            this.ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}