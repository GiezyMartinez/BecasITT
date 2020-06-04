using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BecasITT.Models
{
    public class IngresoMensual
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Parentesco { get; set; }
        public int Edad { get; set; }
        public string Escolaridad { get; set; }
        //¿Este miembro de la familia trabaja(si/no)?
        public string Trabaja { get; set; }
        public string Ocupación { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Ingreso { get; set; }
        //LLave foranea
        public int? BecaID { get; set; }
        public virtual Beca Beca { get; set; }

    }
}