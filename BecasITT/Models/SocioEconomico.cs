﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BecasITT.Models
{
    public class SocioEconomico
    {
        [Key]//Cumple con dos funciones: 1) establece que dicha propiedad es la llave primaria de la tabla. 2) Establece que siempre hace referencia a una Beca, es decir, 
             //que la propiedad en no-null.
        [ForeignKey("Beca")]//Esta propiedad también es la clave externa que establece la relación con el modelo Beca.
        public int BecaID { get; set; }
        public virtual Beca Beca { get; set; }

        public string LugarNacimiento { get; set; }
        //¿Cuentas con visa(si/no)?
        public string Visa { get; set; }
        //¿Cuentas con pasaporte(si/no)?
        public string Pasaporte { get; set; }
        //¿Con quien vives(padres, solo, etc...)?
        public string VivesCon { get; set; }
        //Tiempo viviendo en ese domicilio
        public int TiempoDom { get; set; }
        //¿Cuantas personas viven en la casa?
        public int PersonasCasa { get; set; }
        //La casa es: Propia, Rentada, etc...
        public string PropiedadaCasa { get; set; }
        //Material de los pisos es de: Tierra, Madera, Cemento, etc...
        public string MaterialPiso { get; set; }
        //¿Cuantas recámars tiene?
        public int CantidadRecamaras { get; set; }
        //¿Cuantos baños tiene?
        public int CantidadBaños { get; set; }
        //¿Tiene sala independiente?
        public string SalaIndependiente { get; set; }
        //¿Tiene cocina independiente?
        public string CocinaIndependiente { get; set; }
        //¿Con que servicios cuentan en la casa?
        public string Agua { get; set; }
        public string Luz { get; set; }
        public string Drenaje { get; set; }
        public string Pavimiento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string GasTuberia { get; set; }
        public string TvCable { get; set; }
        public string Internet { get; set; }
        public string TvSatelite { get; set; }
        //Aparatos electrónicos en el hogar
        public string Computadora { get; set; }
        public string Smartphone { get; set; }
        public string Tablet { get; set; }
        //Ventilación de la casa
        public string Ventana { get; set; }
        public string Cooler { get; set; }
        public string Abanico { get; set; }
        public string Calefaccion { get; set; }
        //Cantidad de automóviles en la casa
        public int CantidadAuto { get; set; }
        //¿Qué transporte utilizas?
        public string AuotPropio { get; set; }
        public string AutoFamiliar { get; set; }
        public string Motocicleta { get; set; }
        public string Camion { get; set; }
        public string Taxi { get; set; }
        public string Caminando { get; set; }
        public string Otro { get; set; }
    }
}