using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VYPS.Mvc.Models
{
    public class Notlar
    {
        [Key]
        public int notId { get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        public int no { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int dkod { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int vize { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int final { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public bool durum { get; set; } = true;

        //dkod ders tablosuyla birleşicek
        [ForeignKey("dkod")]
        public Ders Ders { get; set; }
    }
}