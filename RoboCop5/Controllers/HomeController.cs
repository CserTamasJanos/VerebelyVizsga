using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoboCop5.Models;

namespace RoboCop5.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            //RoboCopEntities r = new RoboCopEntities();
            //Navbar n = new Navbar();

            //string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjIyNiIsIm5iZiI6MTY1MTU5MTg3MCwiZXhwIjoxNjUxNTkxOTMwLCJpYXQiOjE2NTE1OTE4NzB9.z2ixPi97FYmhR4w_eelmQMOLLUDcdEOBT4ITfEnasQs";
            //n.UsersMenus = r.UsersMenus(token).ToList();
            //HttpContext.Request.Cookies.Get(token);

            //return View(n);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }




    }
}