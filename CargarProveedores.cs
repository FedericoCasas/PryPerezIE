﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PryPerezIE
{
    public partial class CargarProveedores : Form
    {
        public CargarProveedores()
        {
            InitializeComponent();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal();
            paginaPrincipal.Show();
            this.Close();

        }

        private void CargarProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            StreamWriter NewProveedores = new StreamWriter("Proveedores", true);

            var a = "";

            if (chkActivo.Checked == true) {
                a = "activo";
            } else
                {
                a = "inactivo";
            }

            NewProveedores.WriteLine(txtNombre.Text + " " + txtEmail.Text + " " + txtTelefono.Text + " " + txtDireccion.Text + " " + txtNroTributario.Text + " " + txtComentario.Text + " " + a);

            NewProveedores.Close();




        }
    }
}
