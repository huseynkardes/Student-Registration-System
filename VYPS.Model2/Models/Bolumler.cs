using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYPS.Model2.Models
{
    public class Bolumler
    {
        [Key]
        public int bolumId { get; set; }
        
        public string badi { get; set; }
        
        public int bolumbskn { get; set; }

        [ForeignKey("bolumbskn")]
        public Akademik Akademik { get; set; }
    }
}
