using System.Collections.Generic;

namespace Busco.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public double Precio { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        public ICollection<Solicitud> Solicitudes { get; set; }

    }
}