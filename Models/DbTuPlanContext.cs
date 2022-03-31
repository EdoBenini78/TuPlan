using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TuPlan.Models
{
    public class DbTuPlanContext: DbContext
    {
        public DbSet<Usuario> DbUsuarios { get; set; }
        public DbSet<Inmueble> DbInmuebles { get; set; }
        //public DbSet<FotosInmueble> DbFotosInmueble { get; set; }
        public DbSet<LogErrores> DbLogErrores { get; set; }

        public DbTuPlanContext() : base("TuPlanLocal")
        {

        }
    }
}