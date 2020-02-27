using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HenhoOnline.Models
{
    public class TuVi
    {
        public int Id { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Tuoi { get; set; }
        public string Menh { get; set; }
        public string TuoiHop { get; set; }
        public int Gender { get; set; }
        public string TuViHop { get; set; }
    }
}