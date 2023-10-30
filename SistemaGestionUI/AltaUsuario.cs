﻿using SistemaGestionBussiness;
using SistemaGestionEntities;
using SistemaGestionUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestion
{
    public partial class AltaUsuario : Form
    {
        private bool agregar = true;
        private Usuario _usuario = new Usuario();

        public AltaUsuario()
        {
            InitializeComponent();
        }

        public AltaUsuario(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            agregar = false;
            CargarDatosForm();
        }


        private void CargarDatosForm()
        {
            this.textNombre.Text = _usuario.Nombre;
            this.textApellido.Text = _usuario.Apellido;
            this.textContrasenia.Text = _usuario.Contraseña;
            this.textNombreUsu.Text = _usuario.NombreUsuario;
            this.textMail.Text = _usuario.Mail;
        }

        #region Click Boton Enviar Formulario
        private void EnviarForm_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Id = _usuario.Id;
            usuario.Nombre = textNombre.Text;
            usuario.Apellido = textApellido.Text;
            usuario.NombreUsuario = textNombreUsu.Text;
            usuario.Contraseña = textContrasenia.Text;
            usuario.Mail = textMail.Text;

            if (agregar)
            {
                var respuesta = ContextoUsuarios.GrabarUsuario(usuario);
            }
            else
            {
                ContextoUsuarios.ModificarUsuario(usuario);
            }
            DialogResult = DialogResult.OK;
        }
        #endregion


        private void AltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}