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

        private void CargarListado()
        {
            List<Venta> listado = VentaBussiness.ListarVenta();
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
            ;
        }
    }
}
