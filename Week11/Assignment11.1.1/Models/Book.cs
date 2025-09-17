using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11._1._1.Models
{
    public class Book
    {
        [Key]
        public string isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string summary { get; set; }

    }
}
