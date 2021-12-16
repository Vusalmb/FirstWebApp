using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            //return Content("Index P223");
            ViewResult view = new ViewResult();
            view.ViewName = "Index";
            return view;
        }

        public ActionResult About()
        {
            //return Content("About P223");
            return View();
        }

        public ActionResult Contact()
        {
            //return Content("Contact P223");
            return View();
        }

        public ActionResult FAQ()
        {
            //return Content("Contact P223");
            return View();
        }
    }
}
