using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HenhoOnline.Models
{

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        private ApplicationDbContext dbContext = new ApplicationDbContext();
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public DateTime BirthDay { get; set; }
        public string Address { get; set; }
        public int Gender { get; set; }
        public CharacterType? Character { get; set; }
        public enum CharacterType
        {
            [Display(Name = "Vui vẻ")]
            Funny,
            [Display(Name = "Khó chịu")]
            Angry
        }
        //
        //sua lai prop address chia ra xã, huyen, tinh.
        public int? HoroscopeId { get; set; }

        public int GetHoroscope(ApplicationUser currentUser)
        {
            var horoscope = dbContext.Horoscopes.Where(h =>
                h.StartDate <= currentUser.BirthDay & h.EndDate >= currentUser.BirthDay & h.Gender == currentUser.Gender).First();
            return horoscope.Id;
        }
        public List<ApplicationUser> GetListUserHoroscopeMatch(ApplicationUser currentUser)
        {
            var listUser = new List<ApplicationUser>();
            if (currentUser.HoroscopeId != null)
            {
                var currentHoroscope = dbContext.Horoscopes.Find(currentUser.HoroscopeId);
                var horoscopeMatchIds = currentHoroscope.HoroscopeMatch.Split(',');
                foreach (var horoscopeId in horoscopeMatchIds)
                {
                    var horoscopeIdInt = Int32.Parse(horoscopeId);
                    listUser.AddRange(dbContext.Users.Where(u => u.HoroscopeId == horoscopeIdInt).ToList());
                }
            }
            return listUser;
        }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Horoscope> Horoscopes { get; set; }
    }
}