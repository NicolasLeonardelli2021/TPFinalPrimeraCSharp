namespace SistemaGestionUI
{
    partial class Listado_Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgVentas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Comentarios = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewButtonColumn();
            btnNuevaVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgVentas).BeginInit();
            SuspendLayout();
            // 
            // dgVentas
            // 
            dgVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVentas.Columns.AddRange(new DataGridViewColumn[] { Id, Comentarios, Usuario, Detalle });
            dgVentas.Location = new Point(91, 76);
            dgVentas.Name = "dgVentas";
            dgVentas.RowTemplate.Height = 25;
            dgVentas.Size = new Size(639, 150);
            dgVentas.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Comentarios
            // 
            Comentarios.DataPropertyName = "Comentarios";
            Comentarios.HeaderText = "Comentarios";
            Comentarios.Name = "Comentarios";
            // 
            // Usuario
            // 
            Usuario.DataPropertyName = "Usuario";
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            // 
            // Detalle
            // 
            Detalle.HeaderText = "Detalle";
            Detalle.Name = "Detalle";
            Detalle.Text = "Detalle";
            Detalle.UseColumnTextForButtonValue = true;
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.Location = new Point(606, 47);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Size = new Size(124, 23);
            btnNuevaVenta.TabIndex = 1;
            btnNuevaVenta.Text = "Nueva Venta";
            btnNuevaVenta.UseVisualStyleBackColor = true;
            btnNuevaVenta.Click += btnNuevaVenta_Click;
            // 
            // Listado_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 411);
            Controls.Add(btnNuevaVenta);
            Controls.Add(dgVentas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Listado_Ventas";
            Text = "Listado_Ventas";
            Load += Listado_Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dgVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgVentas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Comentarios;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewButtonColumn Detalle;
        private Button btnNuevaVenta;
    }
}