using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VYPS.Mvc.Models
{
    public class Ders
    {   [Key]
        public int dkod { get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz"),Column(TypeName ="varchar"),MaxLength(50)]
        public string dadi { get; set; }

     
    }
}