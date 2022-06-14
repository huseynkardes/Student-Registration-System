using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYPS.Model2.Models
{
    public class Notlar
    {
        [Key]
        public int notId { get; set; }
        
        public int no { get; set; }
        
        public int dkod { get; set; }
        
        public int vize { get; set; }
        
        public int final { get; set; }
        
        public bool durum { get; set; } = true;

        //dkod ders tablosuyla birleşicek
        [ForeignKey("dkod")]
        public Ders Ders { get; set; }
    }
}
