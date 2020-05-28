using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BecasITT.Models
{
    public class Beca
    {
        public int IdBeca { get; set; }
        public string NombreBeca { get; set; }
        public string Descripcion { get; set; }
        public int IdDatosGral { get; set; }
        public int IdSocioEco { get; set; }
    }
}