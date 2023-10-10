namespace SistemaDeGestion
{
    partial class AltaUsuario
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
            textMail = new TextBox();
            IdUsuario = new Label();
            textContrasenia = new TextBox();
            costo = new Label();
            textNombreUsu = new TextBox();
            stock = new Label();
            textApellido = new TextBox();
            precioVenta = new Label();
            textNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            EnviarForm = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textMail
            // 
            textMail.Location = new Point(132, 314);
            textMail.Name = "textMail";
            textMail.Size = new Size(224, 23);
            textMail.TabIndex = 19;
            // 
            // IdUsuario
            // 
            IdUsuario.AutoSize = true;
            IdUsuario.Location = new Point(35, 317);
            IdUsuario.Name = "IdUsuario";
            IdUsuario.Size = new Size(30, 15);
            IdUsuario.TabIndex = 18;
            IdUsuario.Text = "Mail";
            // 
            // textContrasenia
            // 
            textContrasenia.Location = new Point(132, 266);
            textContrasenia.Name = "textContrasenia";
            textContrasenia.Size = new Size(224, 23);
            textContrasenia.TabIndex = 17;
            // 
            // costo
            // 
            costo.AutoSize = true;
            costo.Location = new Point(35, 266);
            costo.Name = "costo";
            costo.Size = new Size(67, 15);
            costo.TabIndex = 16;
            costo.Text = "Contraseña";
            // 
            // textNombreUsu
            // 
            textNombreUsu.Location = new Point(132, 213);
            textNombreUsu.Name = "textNombreUsu";
            textNombreUsu.Size = new Size(224, 23);
            textNombreUsu.TabIndex = 15;
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Location = new Point(35, 216);
            stock.Name = "stock";
            stock.Size = new Size(91, 15);
            stock.TabIndex = 14;
            stock.Text = "NombreUsuario";
            // 
            // textApellido
            // 
            textApellido.Location = new Point(129, 162);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(227, 23);
            textApellido.TabIndex = 13;
            // 
            // precioVenta
            // 
            precioVenta.AutoSize = true;
            precioVenta.Location = new Point(35, 170);
            precioVenta.Name = "precioVenta";
            precioVenta.Size = new Size(51, 15);
            precioVenta.TabIndex = 12;
            precioVenta.Text = "Apellido";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(129, 114);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(227, 23);
            textNombre.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 117);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 10;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(116, 9);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 0;
            label2.Text = "Alta de Usuario";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 42);
            panel1.TabIndex = 20;
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
            panel2.Size = new Size(373, 45);
            panel2.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(196, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // EnviarForm
            // 
            EnviarForm.Location = new Point(285, 9);
            EnviarForm.Name = "EnviarForm";
            EnviarForm.Size = new Size(75, 23);
            EnviarForm.TabIndex = 10;
            EnviarForm.Text = "Agregar";
            EnviarForm.UseVisualStyleBackColor = true;
            EnviarForm.Click += EnviarForm_Click;
            // 
            // AltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textMail);
            Controls.Add(IdUsuario);
            Controls.Add(textContrasenia);
            Controls.Add(costo);
            Controls.Add(textNombreUsu);
            Controls.Add(stock);
            Controls.Add(textApellido);
            Controls.Add(precioVenta);
            Controls.Add(textNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AltaUsuario";
            Text = "AltaUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textMail;
        private Label IdUsuario;
        private TextBox textContrasenia;
        private Label costo;
        private TextBox textNombreUsu;
        private Label stock;
        private TextBox textApellido;
        private Label precioVenta;
        private TextBox textNombre;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button EnviarForm;
    }
}