using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BecasITT.Models
{
    public class Beca
    {
        public int Id { get; set; }
        public string NombreBeca { get; set; }
        public string Descripcion { get; set; }
        public virtual DatosGral DatosGral { get; set; }
        public virtual SocioEconomico SocioEconomico { get; set; }
    }
}