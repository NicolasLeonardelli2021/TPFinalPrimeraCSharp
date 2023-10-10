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
using SistemaGestionBussiness;

namespace SistemaGestionUI
{
    public partial class Listado_Productos : Form
    {
        public Listado_Productos()
        {
            InitializeComponent();
        }

        private void Listado_Productos_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos()
        {
            List<Producto> lista = ProductoBussiness.GetProductos();
            dgProducto.AutoGenerateColumns = false;
            dgProducto.DataSource = lista;
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            AltaProducto form = new AltaProducto();

            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("El Producto se Grabó correctamente");
                this.cargarProductos();
            };


        }

        private void dgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;


            int Id = (int)this.dgProducto.Rows[e.RowIndex].Cells["id"].Value;
            Producto producto = ProductoBussiness.GetProductos().Where(x => x.Id == Id).FirstOrDefault();

            if (this.dgProducto.Columns[e.ColumnIndex].Name == "Editar")
            {
                AltaProducto form = new AltaProducto(producto);
                //form.FormClosed += form.FormClosed;
                form.ShowDialog();
                cargarProductos();
            }
            else
                if (this.dgProducto.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                ProductoBussiness.EliminarProducto(producto);
                cargarProductos();
            }
        }
    }
}
