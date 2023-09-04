using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryPerezIE
{
    public partial class VerArchivos : Form
    {
        public VerArchivos()
        {
            InitializeComponent();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal();
            paginaPrincipal.Show();
            this.Close();
        }

        private void btnNuevaCarpeta_Click(object sender, EventArgs e)
        {

            //string ruta = lblEjemplo.Text;

            VentanaCarpeta.ShowDialog();

            lblEjemplo.Text = VentanaCarpeta.SelectedPath;
            //seleccionar carpeta

            //treeView1.Nodes.Add





        }
    }
}
