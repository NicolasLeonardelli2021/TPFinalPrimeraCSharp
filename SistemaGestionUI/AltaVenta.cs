using SistemaGestionEntities;
using System.Data;

namespace SistemaGestionUI
{
    public partial class AltaVenta : Form
    {
        private List<Producto> productos = new List<Producto>();
        private List<ProductosLista> productosCarrito = new List<ProductosLista>();
        private ProductosLista productoItem = new ProductosLista();
        private decimal total = 0;


        public AltaVenta()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string Snum = numCatidad.Value.ToString();
            int cantidad = Int32.Parse(Snum);
            decimal precio = decimal.Parse(labelPrecio.Text);
            decimal total = precio * cantidad;
            productoItem.Subtotal = total;
            productoItem.Cantidad = cantidad;
            labelPrecio.Text = total.ToString();
        }





        private void AltaVenta_Load(object sender, EventArgs e)
        {
            CargarComboProductos();
        }

        public async void CargarComboProductos()
        {
            productos = await ContextoProductos.CargarProductos();

            comboProd.DataSource = productos;
            comboProd.DisplayMember = "Descripciones";
            comboProd.ValueMember = "Id";


        }

        private void comboProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            string ItemId = comboProd.SelectedValue.ToString();
            int id = 0;
            if (ItemId != "SistemaGestionEntities.Producto")
            {
                id = Int32.Parse(ItemId);
                Producto prod = productos.Where(x => x.Id == id).FirstOrDefault();
                labelPrecio.Text = prod.PrecioVenta.ToString();
                productoItem.Precio = prod.PrecioVenta;
                productoItem.NombreProducto = prod.Descripciones;
                productoItem.Cantidad = 1;
                productoItem.Subtotal = prod.PrecioVenta;

                numCatidad.Value = 1;
            }
            //int precio2 = comboProd.SelectedIndex;






        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            productosCarrito.Add(productoItem);
            dataGridView1.Rows.Add(productoItem.Id, productoItem.NombreProducto, productoItem.Cantidad, productoItem.Precio, productoItem.Subtotal);
            total += productoItem.Subtotal;
            labelTot.Text = total.ToString();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Id = 1;
            Venta venta = new Venta();
            venta.Comentarios = textComentarios.Text;
            venta.Usuario = user;
            ContextoVentas.GrabarVenta(venta);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
