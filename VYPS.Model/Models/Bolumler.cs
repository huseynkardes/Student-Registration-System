using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace VYPS.Mvc.Models
{
    public class Bolumler
    {
        [Key]
        public int bolumId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string badi { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int bolumbskn { get; set; }

        [ForeignKey("bolumbskn")]
        public Akademik Akademik { get; set; }

        
    }
}