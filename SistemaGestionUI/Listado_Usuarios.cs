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

        public void cargarUsuarios()
        {
            List<Usuario> lista = UsuarioBussiness.GetUsuarios();
            dgUsuario.AutoGenerateColumns = false;
            dgUsuario.DataSource = lista;
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
            Usuario usuario = UsuarioBussiness.GetUsuarios().Where(x => x.Id == Id).FirstOrDefault();

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
                UsuarioBussiness.EliminarUsuario(usuario);
                cargarUsuarios();
            }
        }
    }
}
