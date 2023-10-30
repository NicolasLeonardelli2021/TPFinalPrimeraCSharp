using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
