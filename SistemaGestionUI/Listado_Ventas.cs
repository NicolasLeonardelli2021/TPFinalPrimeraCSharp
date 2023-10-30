using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionEntities;
using SistemaGestionBussiness;
using SistemaDeGestion;

namespace SistemaGestionUI
{
    public partial class Listado_Ventas : Form
    {
        public Listado_Ventas()
        {
            InitializeComponent();
        }

        private void Listado_Ventas_Load(object sender, EventArgs e)
        {
            CargarListado();
        }

        private async void CargarListado()
        {
            List<Venta> listado = await ContextoVentas.CargarVenta();
            List<ModeloTablaVentas> modelo = new List<ModeloTablaVentas>();

            foreach (var item in listado)
            {
                ModeloTablaVentas modTabla = new ModeloTablaVentas();
                modTabla.Id = item.Id;
                modTabla.Comentarios = item.Comentarios;
                modTabla.Usuario = item.Usuario.Nombre + " " + item.Usuario.Apellido;
                modelo.Add(modTabla);
            }

            dgVentas.AutoGenerateColumns = false;
            dgVentas.DataSource = modelo;
            
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            AltaVenta form = new AltaVenta()
            {
                
            };
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("La venta se Grabó correctamente");
                //this.cargarUsuarios();
            };
        }
    }
}
