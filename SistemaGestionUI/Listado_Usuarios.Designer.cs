namespace SistemaGestionUI
{
    partial class Listado_Usuarios
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
            dgUsuario = new DataGridView();
            btnAgregarU = new Button();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Mail = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgUsuario).BeginInit();
            SuspendLayout();
            // 
            // dgUsuario
            // 
            dgUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgUsuario.BackgroundColor = Color.White;
            dgUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuario.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail, Editar, Eliminar });
            dgUsuario.Location = new Point(12, 68);
            dgUsuario.Name = "dgUsuario";
            dgUsuario.RowTemplate.Height = 25;
            dgUsuario.Size = new Size(745, 135);
            dgUsuario.TabIndex = 0;
            dgUsuario.CellContentClick += dgUsuario_CellContentClick;
            // 
            // btnAgregarU
            // 
            btnAgregarU.Location = new Point(610, 39);
            btnAgregarU.Name = "btnAgregarU";
            btnAgregarU.Size = new Size(147, 23);
            btnAgregarU.TabIndex = 1;
            btnAgregarU.Text = "Agregar Usuario";
            btnAgregarU.UseVisualStyleBackColor = true;
            btnAgregarU.Click += btnAgregarU_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "NombreUsuario";
            NombreUsuario.HeaderText = "NombreUsuario";
            NombreUsuario.Name = "NombreUsuario";
            // 
            // Contraseña
            // 
            Contraseña.DataPropertyName = "Contraseña";
            Contraseña.HeaderText = "Contraseña";
            Contraseña.Name = "Contraseña";
            // 
            // Mail
            // 
            Mail.DataPropertyName = "Mail";
            Mail.HeaderText = "Mail";
            Mail.Name = "Mail";
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // Listado_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 411);
            Controls.Add(btnAgregarU);
            Controls.Add(dgUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Listado_Usuarios";
            Text = "Listado_Usuarios";
            Load += Listado_Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgUsuario;
        private Button btnAgregarU;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Mail;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
    }
}