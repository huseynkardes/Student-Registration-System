using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace VYPS.Mvc.Models
{
    public class Ogrenci
    {
        [Key]
        public int no { get; set; }
        public string ad { get; set; }
        public string soyadi { get; set; }
        public int bolumid { get; set; }
        public DateTime dtar { get; set; }
        public string adres { get; set; }
        public int tcno { get; set; }
        public bool cinsiyet { get; set; }
        
        [ForeignKey("bolumid")]
        public Bolumler Bolumler { get; set; }

       
    }
}