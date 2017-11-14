using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using K21t2_Team3.Models;

namespace K21t2_Team3.ViewModels
{
    public class ViewModel
    {
        public List<DISTRICT> zDistricts { get; set; }
        public List<PROPERTY> zProperties { get; set; }
        public List<STREET> zStreets { get; set; }
        public List<WARD> zWards { get; set; }
    }
}