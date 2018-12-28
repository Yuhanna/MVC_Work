using MVC_Git_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Git_Application.Controllers
{
    public class HomeController : Controller
    {
        MVC_Git_ApplicationContext _context = new MVC_Git_ApplicationContext();
        // GET: Home
        public ActionResult Index()
        {
            var products = _context
                .Products
                .Where(i => i.isApproved == true && i.isHome == true)
                .ToList();
            return View(products);
        }
    }
}