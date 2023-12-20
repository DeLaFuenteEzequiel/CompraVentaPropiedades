namespace CompraVenta_api.Models
{
    public class Usuario
    {
         public int UsuarioId { get; set; }
        public required string NombreUsuario { get; set; }
        public required string Contrasenia{get;set;}
        public required string NombreReal { get; set; }
        public required string CorreoElectronico { get; set; }
        public required string Dni { get; set; }
        public required string Localidad { get; set; }
    }
}