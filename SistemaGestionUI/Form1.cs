using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionUI

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Usuario_Click(object sender, EventArgs e)
        {
            if (PanelPrincipal.Controls.Count > 0)
            {
                PanelPrincipal.Controls.RemoveAt(0);
            }
            Listado_Usuarios form = new Listado_Usuarios();
            form.TopLevel = false;
            PanelPrincipal.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PanelPrincipal.Controls.Count > 0)
            {
                PanelPrincipal.Controls.RemoveAt(0);
            }
            Listado_Productos form = new Listado_Productos();
            form.TopLevel = false;
            PanelPrincipal.Controls.Add(form);
            form.Show();
        }
    }
}