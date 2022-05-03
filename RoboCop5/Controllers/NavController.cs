using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoboCop5.Models;

namespace RoboCop5.Controllers
{
    public class NavController : Controller
    {
        private RoboCopEntities db = new RoboCopEntities();
        // GET: Nav
        public ActionResult Navbar(string token)
        {
            Navbar n = new Navbar();
            var cookie = HttpContext.Request.Cookies.Get("token").Value;

            n.UsersMenus = db.UsersMenus(cookie).ToList();



            //RoboCopEntities r = new RoboCopEntities();
            //Navbar n = new Navbar();

            //token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjIyNiIsIm5iZiI6MTY1MTU5MTg3MCwiZXhwIjoxNjUxNTkxOTMwLCJpYXQiOjE2NTE1OTE4NzB9.z2ixPi97FYmhR4w_eelmQMOLLUDcdEOBT4ITfEnasQs";
            //n.UsersMenus = r.UsersMenus(token).ToList();
            //HttpContext.Request.Cookies.Get(token);

            return View(n);
        }
    }
}