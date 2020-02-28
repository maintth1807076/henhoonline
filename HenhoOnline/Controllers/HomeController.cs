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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(string birthDay, int? gender)
        {
            ////para input IdUser. -> user tuong ung , if user nulll -> not found
            //var currentUserId = "A001"; // lay tu session
            //var currentUser = dbContext.Users.Find(currentUserId);
            //if (currentUser == null) return HttpNotFound();
            //List<ApplicationUser> danhsachHopTuVio = new List<ApplicationUser>();
            //if (currentUser.TuviId != null)
            //{
            //   var currentTuvi =  dbContext.TuVis.Find(currentUser.TuviId);
            //   var tuviHopIds = currentTuvi.TuViHop.Split(',');
            //   foreach (var hopId in tuviHopIds)
            //   {
            //       var hopIdInt = Int32.Parse(hopId);
            //       var list = dbContext.Users.Where(u => u.TuviId == hopIdInt).ToList();
            //       danhsachHopTuVio.AddRange(list);
            //   }
            //}

            
            return View();
        }
    }
}