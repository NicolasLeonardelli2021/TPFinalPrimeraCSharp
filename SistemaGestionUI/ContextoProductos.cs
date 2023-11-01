








using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionUI
{
    public class ContextoProductos
    {
        #region Get Productos
        public static async Task<List<Producto>> CargarProductos()
        {
            HttpClient client = new HttpClient();
            List<Producto>? list = null;
            try
            {
                string path = @"https://localhost:7263/api/Productos";
                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                {
                    list = await response.Content.ReadFromJsonAsync<List<Producto>>();

                }
                return list;
            }
            catch (Exception)
            {

                return list;
            }

        }
        #endregion

        #region  POST Grabar Producto
        public static async Task<bool> GrabarProducto(Producto producto)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7263/api/Productos";

            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(path, producto);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Se dio de alta correctamente");
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar dar de alta");
                    return false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al intentar dar de alta");
                return false;
            }

        }
        #endregion

        #region  Traer un Producto
        public static async Task<Producto> ObtenerProducto(int id)
        {
            HttpClient client = new HttpClient();
            List<Producto>? list = null;
            try
            {
                string path = @"https://localhost:7263/api/Productos";
                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                {
                    list = await response.Content.ReadFromJsonAsync<List<Producto>>();

                }
                return list.Where(x => x.Id == id).FirstOrDefault();

            }
            catch (Exception)
            {
                return null;

            }
        }
        #endregion

        #region  PUT Grabar Producto Editado
        public static async Task<bool> ModificarProducto(Producto producto)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7263/api/Productos";

            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync(path, producto);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Se modifico correctamente");
                    //this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar dar de alta");
                    return false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al intentar dar de alta");
                return false;
            }

        }
        #endregion

        #region DELETE Borrar Producto
        public static async Task<bool> EliminarProducto(Producto producto)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7263/api/Productos";

            try
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = JsonContent.Create(producto.Id),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(path, UriKind.Absolute)
                };



                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Se elimino correctamente");
                    //this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar el usuario");
                    return false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al eliminar el usuario");
                return false;
            }

        }
        #endregion
    }
}

