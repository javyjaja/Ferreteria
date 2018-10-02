using Ferreteria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ferreteria.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new context();
            var p = new producto { cantidad = 1, precio = 10, categoriaId = 1 };
            db.products.Add(p);
            db.SaveChanges();
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
        public ActionResult Login(loginModel o)
        {
            if (o.userName != null)
            {
                return View("Index");
            }
            return View();
        }
    }
}