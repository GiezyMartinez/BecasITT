using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BecasITT.Models;
using System.Data.Entity;

namespace BecasITT.DAL
{
    public class BecasITTContext: DbContext
    {
        
            public BecasITTContext() : base("BecasITTContext")
            {
            }
            public DbSet<Alumno> Alumnos { get; set; }
            public DbSet<Beca> Becas { get; set; }
            public DbSet<DatosGral> DatosGrals { get; set; }
            public DbSet<SocioEconomico> SocioEconomicos { get; set; }
            public DbSet<IngresoMensual> IngresoMensuals { get; set; }
        
    }
}