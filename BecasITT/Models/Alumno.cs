using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BecasITT.Models
{
    public class Alumno
    {

        public int ID { set; get; }
        public int Noctrl { get; set; }
        public string CorreoIns { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string Contraseña { get; set; }
        public virtual Beca Beca { get; set; }
    }
}