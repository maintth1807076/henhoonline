using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HenhoOnline.Models
{
    public class Horoscope
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string NegativeAge { get; set; }
        public string FiveElements { get; set; }
        public int Gender { get; set; }
        public string HoroscopeMatch { get; set; }
    }
}