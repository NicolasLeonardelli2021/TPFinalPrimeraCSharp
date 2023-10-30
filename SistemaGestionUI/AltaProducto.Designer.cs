namespace SistemaGestionUI
{
    partial class AltaProducto
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
            panel1 = new Panel();
            label1 = new Label();
            IdUsuario = new Label();
            numCosto = new TextBox();
            costo = new Label();
            numStock = new TextBox();
            stock = new Label();
            numPrecio = new TextBox();
            precioVenta = new Label();
            textDescripcion = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            EnviarForm = new Button();
            comboBoxUser = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 0;
            label1.Text = "Alta Producto";
            // 
            // IdUsuario
            // 
            IdUsuario.AutoSize = true;
            IdUsuario.Location = new Point(6, 298);
            IdUsuario.Name = "IdUsuario";
            IdUsuario.Size = new Size(57, 15);
            IdUsuario.TabIndex = 18;
            IdUsuario.Text = "IdUsuario";
            // 
            // numCosto
            // 
            numCosto.Location = new Point(81, 244);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(100, 23);
            numCosto.TabIndex = 17;
            // 
            // costo
            // 
            costo.AutoSize = true;
            costo.Location = new Point(6, 247);
            costo.Name = "costo";
            costo.Size = new Size(38, 15);
            costo.TabIndex = 16;
            costo.Text = "Costo";
            // 
            // numStock
            // 
            numStock.Location = new Point(81, 194);
            numStock.Name = "numStock";
            numStock.Size = new Size(114, 23);
            numStock.TabIndex = 15;
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Location = new Point(6, 197);
            stock.Name = "stock";
            stock.Size = new Size(36, 15);
            stock.TabIndex = 14;
            stock.Text = "Stock";
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(81, 143);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(114, 23);
            numPrecio.TabIndex = 13;
            // 
            // precioVenta
            // 
            precioVenta.AutoSize = true;
            precioVenta.Location = new Point(6, 151);
            precioVenta.Name = "precioVenta";
            precioVenta.Size = new Size(72, 15);
            precioVenta.TabIndex = 12;
            precioVenta.Text = "Precio Venta";
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(81, 95);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(227, 23);
            textDescripcion.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 98);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 10;
            label2.Text = "Descripcion";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(EnviarForm);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 405);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 45);
            panel2.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(230, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EnviarForm
            // 
            EnviarForm.Location = new Point(311, 9);
            EnviarForm.Name = "EnviarForm";
            EnviarForm.Size = new Size(75, 23);
            EnviarForm.TabIndex = 10;
            EnviarForm.Text = "Agregar";
            EnviarForm.UseVisualStyleBackColor = true;
            EnviarForm.Click += EnviarForm_Click;
            // 
            // comboBoxUser
            // 
            comboBoxUser.FormattingEnabled = true;
            comboBoxUser.Location = new Point(81, 295);
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(121, 23);
            comboBoxUser.TabIndex = 21;
            comboBoxUser.SelectedIndexChanged += comboBoxUser_SelectedIndexChanged;
            // 
            // AltaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(396, 450);
            Controls.Add(comboBoxUser);
            Controls.Add(panel2);
            Controls.Add(IdUsuario);
            Controls.Add(numCosto);
            Controls.Add(costo);
            Controls.Add(numStock);
            Controls.Add(stock);
            Controls.Add(numPrecio);
            Controls.Add(precioVenta);
            Controls.Add(textDescripcion);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AltaProducto";
            Text = "AltaProducto";
            Load += AltaProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Label label1;
        private Label IdUsuario;
        private TextBox numCosto;
        private Label costo;
        private TextBox numStock;
        private Label stock;
        private TextBox numPrecio;
        private Label precioVenta;
        private TextBox textDescripcion;
        private Label label2;
        private Panel panel2;
        private Button button1;
        private Button EnviarForm;
        private ComboBox comboBoxUser;
    }
}