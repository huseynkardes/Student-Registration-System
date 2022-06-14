using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYPS.Model2.Models
{
    public class Aka_Ders
    {
        [Key]
        public int akaId { get; set; }
        
        public int pkod { get; set; }
        
        public int dkod { get; set; }


        //dkod ders tablosuna bağlanılcak
        [ForeignKey("dkod")]
        public Ders Ders { get; set; }
        [ForeignKey("pkod")]
        public Akademik Akademik { get; set; }

    }
}
