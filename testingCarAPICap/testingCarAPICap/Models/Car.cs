using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testingCarAPICap.Models
{
    public class Rootobject
    {
        public Car[] carList { get; set; }
    }

    public class Car
    {
        public int id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public string color { get; set; }

        public override string ToString()
        {
            return @$"{make}, {model}, {year}, {color}";
        }
    }


}
