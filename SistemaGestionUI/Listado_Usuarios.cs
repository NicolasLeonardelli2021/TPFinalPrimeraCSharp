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

        private  void Listado_Usuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private async void cargarUsuarios()
        {
            List<Usuario> list = await ContextoUsuarios.cargarUsuarios();
            dgUsuario.AutoGenerateColumns = false;
            dgUsuario.DataSource = list;
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

        private async void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;


            int Id = (int)this.dgUsuario.Rows[e.RowIndex].Cells["id"].Value;
            Usuario usuario = await ContextoUsuarios.ObtenerUsuario(Id);

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

                await ContextoUsuarios.EliminarUsuario(usuario);
                cargarUsuarios();
            }
        }

    }
}
