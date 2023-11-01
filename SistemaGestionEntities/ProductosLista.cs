using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class ProductosLista
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }
        
        public decimal Subtotal { get; set; }
    }
}
