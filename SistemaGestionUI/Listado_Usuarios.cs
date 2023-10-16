using SistemaDeGestion;
using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class Listado_Usuarios : Form
    {
        public Listado_Usuarios()
        {
            InitializeComponent();
        }

        private async Task cargarUsuarios()
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
                    dgUsuario.AutoGenerateColumns = false;
                    dgUsuario.DataSource = list;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Listado_Usuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void btnAgregarU_Click(object sender, EventArgs e)
        {
            AltaUsuario form = new AltaUsuario();

            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("El Usuario se Grabó correctamente");
                this.cargarUsuarios();
            };
        }

        private void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;


            int Id = (int)this.dgUsuario.Rows[e.RowIndex].Cells["id"].Value;
            Usuario usuario = cargarUsuarios.Where(x => x.Id == Id).FirstOrDefault();

            if (this.dgUsuario.Columns[e.ColumnIndex].Name == "Editar")
            {
                AltaUsuario form = new AltaUsuario(usuario);
                //form.FormClosed += form.FormClosed;
                form.ShowDialog();
                cargarUsuarios();
            }
            else
                if (this.dgUsuario.Columns[e.ColumnIndex].Name == "Eliminar")
            {

                EliminarUsuario(usuario);




                //UsuarioBussiness.EliminarUsuario(usuario);
                //cargarUsuarios();
            }
        }


        private async Task<bool> EliminarUsuario(Usuario usuario)
        {
           string path = @"https://localhost:7263/api/Usuarios";
            HttpClient client = new HttpClient();

            try
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    Content = JsonContent.Create(usuario),
                    RequestUri = new Uri(path, UriKind.Absolute)
                };
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                if(response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Se elimino correctamente");
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar eliminar el Usuario");
                    return false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar eliminar el Usuario");
                return false;
            }
        }
    }
}
