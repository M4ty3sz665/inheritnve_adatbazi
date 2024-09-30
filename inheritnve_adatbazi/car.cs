using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritnve_adatbazi
{
    class car
    {
        public static List<car> cars = new List<car>();
        public string make { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public int  year { get; set; }
        public int  hp { get; set; }
        public int id { get; set; }
    }
}
