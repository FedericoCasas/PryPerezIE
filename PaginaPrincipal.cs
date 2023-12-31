﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPerezIE
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void PaginaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void agragarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarProveedores cargarProveedores = new CargarProveedores();
            cargarProveedores.Show();
            this.Hide();

        }

        private void verArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerArchivos verArchivo = new VerArchivos();
            verArchivo.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
