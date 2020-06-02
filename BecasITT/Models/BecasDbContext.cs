using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BecasITT.Models
{
    public class BecasDbContext : DbContext
    {
        public DbSet<Alumno> Alumnos{ get; set; }
        public DbSet<Beca> Becas { get; set; }
        public DbSet<DatosGral> DatosGrals { get; set; }
        public DbSet<SocioEconomico> SocioEconomicos { get; set; }
        public DbSet<IngresoMensual> IngresoMensuals { get; set; }
    }
}