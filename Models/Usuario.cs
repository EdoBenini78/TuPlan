using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TuPlan.Models
{
    public class Usuario
    {
        [Key] public int Id { get; set; }
        public string Usario { get; set; }
        public string Password { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id, string usario, string password)
        {
            Id = id;
            Usario = usario;
            Password = password;
        }
    }
}