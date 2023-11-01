namespace SistemaGestionUI
{
    partial class AltaVenta
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
            comboProd = new ComboBox();
            label1 = new Label();
            numCatidad = new NumericUpDown();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            labelTot = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            labelPrecio = new Label();
            btnAgregarProd = new Button();
            button1 = new Button();
            button2 = new Button();
            textComentarios = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numCatidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboProd
            // 
            comboProd.FormattingEnabled = true;
            comboProd.Location = new Point(32, 63);
            comboProd.Name = "comboProd";
            comboProd.Size = new Size(175, 23);
            comboProd.TabIndex = 0;
            comboProd.SelectedIndexChanged += comboProd_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 45);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Producto";
            // 
            // numCatidad
            // 
            numCatidad.Location = new Point(230, 64);
            numCatidad.Name = "numCatidad";
            numCatidad.Size = new Size(55, 23);
            numCatidad.TabIndex = 2;
            numCatidad.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 45);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Cantidad";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, NombreProducto, Cantidad, Precio, Subtotal });
            dataGridView1.Location = new Point(16, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(581, 150);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // NombreProducto
            // 
            NombreProducto.DataPropertyName = "NombreProducto";
            NombreProducto.HeaderText = "NombreProducto";
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.DataPropertyName = "Subtotal";
            Subtotal.HeaderText = "subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelTot);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(32, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 229);
            panel1.TabIndex = 5;
            // 
            // labelTot
            // 
            labelTot.AutoSize = true;
            labelTot.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTot.Location = new Point(477, 195);
            labelTot.Name = "labelTot";
            labelTot.Size = new Size(19, 21);
            labelTot.TabIndex = 7;
            labelTot.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(355, 195);
            label4.Name = "label4";
            label4.Size = new Size(129, 21);
            label4.TabIndex = 6;
            label4.Text = "Total Compra: $";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(15, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 5;
            label3.Text = "Productos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 45);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 6;
            label5.Text = "Precio Unidad";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(323, 66);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(13, 15);
            labelPrecio.TabIndex = 7;
            labelPrecio.Text = "0";
            labelPrecio.Click += label6_Click;
            // 
            // btnAgregarProd
            // 
            btnAgregarProd.Location = new Point(465, 63);
            btnAgregarProd.Name = "btnAgregarProd";
            btnAgregarProd.Size = new Size(140, 23);
            btnAgregarProd.TabIndex = 8;
            btnAgregarProd.Text = "Agregar Producto";
            btnAgregarProd.UseVisualStyleBackColor = true;
            btnAgregarProd.Click += btnAgregarProd_Click;
            // 
            // button1
            // 
            button1.Location = new Point(555, 404);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 9;
            button1.Text = "Grabar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(465, 404);
            button2.Name = "button2";
            button2.Size = new Size(80, 23);
            button2.TabIndex = 10;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textComentarios
            // 
            textComentarios.Location = new Point(32, 366);
            textComentarios.Name = "textComentarios";
            textComentarios.Size = new Size(618, 23);
            textComentarios.TabIndex = 11;
            textComentarios.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 348);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 12;
            label6.Text = "Comentarios";
            // 
            // AltaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 439);
            Controls.Add(label6);
            Controls.Add(textComentarios);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAgregarProd);
            Controls.Add(labelPrecio);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(numCatidad);
            Controls.Add(label1);
            Controls.Add(comboProd);
            Name = "AltaVenta";
            Text = "AltaVenta";
            Load += AltaVenta_Load;
            ((System.ComponentModel.ISupportInitialize)numCatidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboProd;
        private Label label1;
        private NumericUpDown numCatidad;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label3;
        private Label labelTot;
        private Label label4;
        private Label label5;
        private Label labelPrecio;
        private Button btnAgregarProd;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
        private TextBox textComentarios;
        private Label label6;
    }
}