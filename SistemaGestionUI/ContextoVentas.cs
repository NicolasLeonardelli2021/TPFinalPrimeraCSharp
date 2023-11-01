using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionUI
{
    public class ContextoVentas
    {
        #region Get Ventas
        public static async Task<List<Venta>> CargarVenta()
        {
            HttpClient client = new HttpClient();
            List<Venta>? list = null;
            try
            {
                string path = @"https://localhost:7263/api/Venta";
                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                {
                    list = await response.Content.ReadFromJsonAsync<List<Venta>>();

                }
                return list;
            }
            catch (Exception)
            {

                return list;
            }

        }
        #endregion

        #region  POST Grabar Venta
        public static async Task<bool> GrabarVenta(Venta venta)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7263/api/Venta";

            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(path, venta);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Se dio de alta correctamente");
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
    }
}
