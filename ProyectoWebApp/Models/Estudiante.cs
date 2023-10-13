using System.ComponentModel.DataAnnotations;

namespace ProyectoWebApp.Models
{
    public class Estudiante
    {
        [Key]
        public int idEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public bool Sexo { get; set; }
        public int idUniversidad { get; set; }
    }
}
