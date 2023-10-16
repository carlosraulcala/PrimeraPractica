using System.ComponentModel.DataAnnotations;
namespace ProyectoWebApp.Models
{
    public class Materia
    {
        [Key]
        public int idMateia { get; set; }
        public string Nombre { get; set; }
        public int idDocente { get; set; }
    }
}
