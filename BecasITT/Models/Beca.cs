using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BecasITT.Models
{
    public class Beca
    {
        public int ID { get; set; }
        public string NombreBeca { get; set; }
        public string Descripcion { get; set; }
        public virtual DatosGral DatosGral { get; set; } //El hecho de que sea virtual le establece una propiedad NULL, es decir que la beca puede tener o no tener
                                                         //un formulario de Datos Generales.
        public virtual SocioEconomico SocioEconomico { get; set; } //El hecho de que sea virtual le establece una propiedad NULL, es decir que la beca puede tener o no tener
                                                                   //un formulario de estudio socio económico
        public virtual IList<IngresoMensual> IngresoMensuals { get; set; }
        [ForeignKey("Alumno")]
        public int AlumnoID { get; set; }

        public virtual Alumno Alumno { get; set; }
    }
}