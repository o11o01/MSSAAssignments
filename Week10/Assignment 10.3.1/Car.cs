using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment_10._3._1
{
    public class Car
    {

        [Key]
        public string Vin { get; set; }
        public string Manufacture { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }

    }
}
