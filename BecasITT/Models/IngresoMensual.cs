using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BecasITT.Models
{
    public class IngresoMensual
    {
        public int IdIngreso { get; set; }
        public string Nombre { get; set; }
        public string Parentesco { get; set; }
        public int Edad { get; set; }
        public string Escolaridad { get; set; }
        //¿Este miembro de la familia trabaja(si/no)?
        public string Trabaja { get; set; }
        public string Ocupación { get; set; }
        public double Ingreso { get; set; }
    }
}