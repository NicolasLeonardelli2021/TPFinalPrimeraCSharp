﻿using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionUI
{
    public class ContextoUsuarios
    {
        #region Get Usuarios
        public static async Task<List<Usuario>> cargarUsuarios()
        {
            HttpClient client = new HttpClient();
            List<Usuario>? list = null;
            try
            {
                string path = @"https://localhost:7263/api/Usuarios";
                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                {
                    list = await response.Content.ReadFromJsonAsync<List<Usuario>>();

                }
                return list;
            }
            catch (Exception)
            {

                return list;
            }

        }
        #endregion

        #region  POST Grabar Usuario
        public static async Task<bool> GrabarUsuario(Usuario usuario)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7263/api/Usuarios";

            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(path, usuario);
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

        #region POST Traer un Usuario
        public static async Task<Usuario> ObtenerUsuario(int id)
        {
            HttpClient client = new HttpClient();
            List<Usuario>? list = null;
            try
            {
                string path = @"https://localhost:7263/api/Usuarios";
                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                {
                    list = await response.Content.ReadFromJsonAsync<List<Usuario>>();

                }
                return list.Where(x => x.Id == id).FirstOrDefault();

            }
            catch (Exception)
            {
                return null;

            }
        }
        #endregion

        #region  PUT Grabar Usuario Editado
        public static async Task<bool> ModificarUsuario(Usuario usuario)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7263/api/Usuarios";

            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync(path, usuario);
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

        #region DELETE Borrar Usuario
        public static async Task<bool> EliminarUsuario(Usuario usuario)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7263/api/Usuarios";

            try
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = JsonContent.Create(usuario.Id),
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

