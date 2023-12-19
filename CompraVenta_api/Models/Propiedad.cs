namespace CompraVenta_api.Models
{
    public class Propiedad
    {
    public int PropiedadId { get; set; }

    public required string Titulo { get; set; } 

    public required string Descripcion { get; set; }

    public required double MetrosCuadrados { get; set; }

    public required int Ambientes { get; set; }

    public required decimal Valor { get; set; }
    }
}