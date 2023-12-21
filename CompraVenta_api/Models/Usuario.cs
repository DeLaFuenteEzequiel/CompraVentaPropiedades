using System.ComponentModel.DataAnnotations;

namespace CompraVenta_api.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [Required]
        public string NombreUsuario { get; set; } = string.Empty;

        [Required]
        public string Contrasenia { get; set; } = string.Empty;

        [Required]
        public string NombreReal { get; set; } = string.Empty;

        [Required]
        public string CorreoElectronico { get; set; } = string.Empty;

        [Required]
        public string Dni { get; set; } = string.Empty;

        [Required]
        public string Localidad { get; set; } = string.Empty;

        public required decimal Registro { get; set; }
    }
}
