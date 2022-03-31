using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TuPlan.Models
{
    public enum TipoInmueble
    {
        [Description("Apartamento")] Apartamento = 1,
        [Description("Casa")] Casa = 2,
        [Description("Negocio")] Negocio = 3
    }
}