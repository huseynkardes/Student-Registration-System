using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYPS.Model2.Models
{
    public class Akademik
    {
        [Key]
        public int pkod { get; set; }
        
        public int sicilNo { get; set; }
        
        public string padi { get; set; }
        
        public string psoyadi { get; set; }
    }
}
