using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
        public static List<Producto> GetProductos()
        {
            return ProductoData.ListarProducto();
        }

        public static void crearProducto(Producto producto)
        {
            ProductoData.crearProducto(producto);
        }

        public static void ModificarProducto(Producto producto)
        {
            ProductoData.ModificarProducto(producto);
        }

        public static void EliminarProducto(Producto producto)
        {
            ProductoData.EliminarProducto(producto);
        }



    }
}
