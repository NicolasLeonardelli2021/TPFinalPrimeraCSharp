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
using SistemaGestionEntities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaGestionUI
{
    public partial class AltaProducto : Form
    {
        private bool agregar = true;
        private Producto _producto = new Producto();

        public AltaProducto()
        {
            InitializeComponent();
        }

        public AltaProducto(Producto producto)
        {
            InitializeComponent();
            _producto = producto;
            agregar = false;
            CargarDatosForm();
        }

        private void CargarDatosForm()
        {
            CargarCombo();

            this.textDescripcion.Text = _producto.Descripciones;
            this.numCosto.Text = _producto.Costo.ToString();
            this.numPrecio.Text = _producto.PrecioVenta.ToString();
            this.numStock.Text = _producto.Stock.ToString();
            //this.numIdUsuario.Text = _producto.IdUsuario.ToString();
        }


        public void CargarCombo()
        {
            List<Usuario> listado = UsuarioBussiness.GetUsuarios();
            ComboboxItem item = new ComboboxItem();
            foreach (var items in listado)
            {
                item.Text = items.Nombre + " " + items.Apellido;
                item.Value = items.Id;
                comboBoxUser.Items.Add(item);

            }
        }

        private void AltaProducto_Load(object sender, EventArgs e)
        {

            CargarCombo();
        }

        private void EnviarForm_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            //producto.Id = _producto.Id;
            producto.Descripciones = textDescripcion.Text;
            producto.Costo = Decimal.Parse(numCosto.Text);
            producto.Stock = Int32.Parse(numStock.Text);
            producto.PrecioVenta = Decimal.Parse(numPrecio.Text);
            producto.IdUsuario = Int32.Parse((comboBoxUser.SelectedItem as ComboboxItem).Value.ToString());

            //if (agregar)
            //{
                ProductoBussiness.crearProducto(producto);
            //}
            //else
            //{
                //UsuarioBussiness.EditarUsuario(usuario);
            //}
            DialogResult = DialogResult.OK;
        }
    }
}
