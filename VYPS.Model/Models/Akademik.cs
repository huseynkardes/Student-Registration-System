using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace VYPS.Mvc.Models
{
    public class Akademik
    {
       [Key]
        public int pkod { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz"), Column(TypeName = "int")]
        public int sicilNo { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz"), Column(TypeName = "varchar"), MaxLength(50)]
        public string padi { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz"), Column(TypeName = "varchar"), MaxLength(50)]
        public string psoyadi { get; set; }
        //[Required(ErrorMessage = "Bu alan boş bırakılamaz"),Column(TypeName ="int")]
       // public int bolumId{ get; set; }


        //[ForeignKey("bolumId")]
        //public Bolumler Bolumler { get; set; }
        //[InverseProperty("Akademik")] 
        //public virtual ICollection<Bolumler> BolumlerAs { get; set; }
    }
}