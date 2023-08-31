using System;
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
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
        }

        private void tmProgreso_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            lblPorcentaje.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum) {

                tmProgreso.Stop();
                this.Hide();
                PaginaPrincipal frmNewPagina = new PaginaPrincipal();
                frmNewPagina.Show();

            }


        }
    }
}
