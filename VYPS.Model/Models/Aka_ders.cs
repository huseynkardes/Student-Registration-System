using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VYPS.Mvc.Models
{
    public class Aka_ders
    {   
        [Key]
        public int akaId { get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        public int pkod { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int dkod { get; set; }


        //dkod ders tablosuna bağlanılcak
        [ForeignKey("dkod")]
        public Ders Ders { get; set; }
        [ForeignKey("pkod")]
        public Akademik Akademik { get; set; }



    }
}