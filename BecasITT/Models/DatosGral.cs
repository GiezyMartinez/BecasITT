using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BecasITT.Models
{
    public class DatosGral
    { //El ID de la clase Beca es también el ID de esta clase, y al mismo tiempo es la llave foranea que establce la relación con el modelo Beca.
        [Key] //Llave primaria
        [ForeignKey("Beca")] //Realiza la referencia de relación con la clase Beca.
        public int BecaID { get; set; }
        public virtual Beca Beca { get; set; } //Propiedad de navegación que establece la relación uno a uno entre la clases Beca y DatosGral.
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public int Noctrol { get; set; }
        public string Carrera { get; set; }
        public int SemestreActual { get; set; }
        public double PromediGral { get; set; }
        public string Dirección { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNac { get; set; }
        public string EstadoCivil { get; set; }

        public uint Telefono { get; set; }
        public uint Celular { get; set; }
       
    }
}