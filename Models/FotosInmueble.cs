using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace TuPlan.Models
{
    public class FotosInmueble
    {
        [Key] public int Id { get; set; }
        [Required] public virtual Inmueble Inmueble { get; set; }
        [Required] public Bitmap FotoInmuble { get; set; }

        public FotosInmueble()
        {
        }

        public FotosInmueble(int id, Inmueble inmueble, Bitmap fotoInmuble)
        {
            Id = id;
            Inmueble = inmueble;
            FotoInmuble = fotoInmuble;
        }
    }
}