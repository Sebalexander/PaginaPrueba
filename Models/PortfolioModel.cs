using System.ComponentModel.DataAnnotations;

namespace PaginaPrueba.Models
{
    public class Profesional
    {  
        [Key]
        public required string Id { get; set; }

        public required string Nombres { get; set; }

        public required string ApPaterno { get; set; }

        public string? ApMaterno { get; set; }

        public DateTime FechaNacimiento { get; set; }

        

    }
}
