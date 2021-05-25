using System.Collections.Generic;

namespace Busco.Models
{
    public class Comprador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public ICollection<Producto> Productos { get; set; }
        public ICollection<Solicitud> Solicitudes { get; set; }
    }
}