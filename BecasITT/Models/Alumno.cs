using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BecasITT.Models
{
    public class Alumno
    {

        public int IdAlumno { set; get; }
        public int Noctrl { get; set; }
        public string CorreoIns { get; set; }
        public string Contraseña { get; set; }
        public int IdBeca { get; set; }
    }
}