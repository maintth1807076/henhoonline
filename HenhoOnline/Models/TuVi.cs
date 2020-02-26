using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HenhoOnline.Models
{
    public class TuVi
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Tuoi { get; set; }
        public string Menh { get; set; }
        public string TuoiHop { get; set; }
        public int Gender { get; set; }
    }
}