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
    public partial class AltaVenta : Form
    {
        private List<Producto> productos = new List<Producto>();
        public AltaVenta()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }





        private void AltaVenta_Load(object sender, EventArgs e)
        {
            CargarComboProductos();
        }

        public async void CargarComboProductos()
        {
            productos = await ContextoProductos.CargarProductos();
            ComboboxItem item = new ComboboxItem();
            foreach (var items in productos)
            {
                item.Text = items.Descripciones;
                item.Value = items.Id;
                comboProd.Items.Add(item);

            }
        }

        private void comboProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int idProducto = Int32.Parse((comboProd.SelectedValue as ComboboxItem).Value.ToString());

            int idProducto= Int32.Parse((comboProd.SelectedItem as ComboboxItem).Value.ToString());
            Producto prod = productos.Where(x => x.Id == idProducto).FirstOrDefault();

            labelPrecio.Text = prod.PrecioVenta.ToString();
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
