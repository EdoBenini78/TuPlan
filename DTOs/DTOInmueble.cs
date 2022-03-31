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
        public string Duenio { get; set; }
        public int Telefono { get; set; }
        public string MailDuenio { get; set; }

        public DTOInmueble(Inmueble inmueble)
        {
            Id = inmueble.Id;
            Direccion = inmueble.Direccion;
            Descripcion = inmueble.Descripcion;
            Precio = inmueble.Precio;
            Tipo = inmueble.Tipo;
            Destacado =inmueble .Destacado;
            Duenio = inmueble.Duenio;
            Telefono = inmueble.Telefono;
            MailDuenio = inmueble.MailDuenio;
        }
    }
}