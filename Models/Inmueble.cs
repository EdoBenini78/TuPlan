using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace TuPlan.Models
{
    public class Inmueble
    {
        [Key] public int Id { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public TipoInmueble Tipo { get; set; }
        public bool Destacado { get; set; }
        public string Duenio { get; set; }
        public int Telefono { get; set; }
        public string MailDuenio { get; set; }

        public Inmueble()
        {
        }

        public Inmueble(int id, string direccion, string descripcion, decimal precio, TipoInmueble tipo, bool destacado, string duenio, int telefono, string mailDuenio)
        {
            Id = id;
            Direccion = direccion;
            Descripcion = descripcion;
            Precio = precio;
            Tipo = tipo;
            Destacado = destacado;
            Duenio = duenio;
            Telefono = telefono;
            MailDuenio = mailDuenio;
        }
    }
}