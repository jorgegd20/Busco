namespace Busco.Models
{
    public class Solicitud
    {
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public Comprador Comprador { get; set; }
        public int CompradorId { get; set; }
        public string Lugar { get; set; }
    }
}