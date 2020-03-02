using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HenhoOnline.Models;

namespace HenhoOnline.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private ApplicationDbContext dbContext = new ApplicationDbContext();
        // GET: Admin
        public ActionResult Index()
        {
            var listUSer = dbContext.Users.ToList();
            return View(listUSer);
        }
    }
}