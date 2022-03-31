using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TuPlan.Models;

namespace TuPlan.DTOs
{
    public class DTOInmueble
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public TipoInmueble Tipo { get; set; }
        public bool Destacado { get; set; }
        public string Propietario { get; set; }
        public int Telefono { get; set; }
        public string MailPropietario { get; set; }

        public DTOInmueble(Inmueble inmueble)
        {
            Id = inmueble.Id;
            Direccion = inmueble.Direccion;
            Descripcion = inmueble.Descripcion;
            Precio = inmueble.Precio;
            Tipo = inmueble.Tipo;
            Destacado =inmueble .Destacado;
            Propietario = inmueble.Propietario;
            Telefono = inmueble.Telefono;
            MailPropietario = inmueble.MailPropietario;
        }
    }
}