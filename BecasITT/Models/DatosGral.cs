using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BecasITT.Models
{
    public class DatosGral
    {
        public int IdDatosGral { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public int Noctrol { get; set; }
        public string Carrera { get; set; }
        public int SemestreActual { get; set; }
        public double PromediGral { get; set; }
        public string Dirección { get; set; }
        public DateTime FechaNac { get; set; }
        public string EstadoCivil { get; set; }

        public uint Telefono { get; set; }
        public uint Celular { get; set; }
    }
}