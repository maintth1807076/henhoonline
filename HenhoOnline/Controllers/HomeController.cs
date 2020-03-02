using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using HenhoOnline.Models;
using Microsoft.AspNet.Identity;
using WebGrease.Css.Ast.Selectors;

namespace HenhoOnline.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext dbContext = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            {
                Account account = new Account(
                    "kuramakyubi",
                    "469835146884474",
                    "RWvZ8mplFWQncYjejuyXPaKcEdc");

                Cloudinary cloudinary = new Cloudinary(account);
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(file.FileName, file.InputStream)
                };
                var uploadResult = cloudinary.Upload(uploadParams);
                ViewBag.Url = uploadResult.Uri;
            }
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        [Authorize]
        public ActionResult MatchLover()
        {
            Debug.WriteLine(User.Identity.GetUserId());
            var currentUser = dbContext.Users.Find(User.Identity.GetUserId());
            if (currentUser == null) return HttpNotFound();
            var listUser = currentUser.GetListUserHoroscopeMatch(currentUser);
            return View(listUser);
        }

    }
}