using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYPS.Model2.Models
{
    public class Ders
    {
        [Key]
        public int dkod { get; set; }
        
        public string dadi { get; set; }
    }
}
