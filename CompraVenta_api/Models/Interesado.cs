namespace CompraVenta_api.Models
{
    public class Interesado
    {
        public int InteresadoId { get; set; }

        public required string CorreoElectronico { get; set; }

        public required string Publicacion{get ; set;}

         public required decimal registro{get ; set;}
    }
}