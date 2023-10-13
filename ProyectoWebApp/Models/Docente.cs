﻿using System.ComponentModel.DataAnnotations;

namespace ProyectoWebApp.Models
{
    public class Docente
    {
        [Key]
        public int idDocente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ubicacion { get; set; }
        public bool Sexo { get; set; }
        public string CI { get; set; }
        public int idUniversidad { get; set; }
    }
}
