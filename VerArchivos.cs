using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using PryPerezIE.Properties;
using System.Data;
using System.Windows.Forms;

namespace PryPerezIE
{
    public partial class VerArchivos : Form
    {
        private CargarProveedores modificarProveedor;
        public VerArchivos()
        {
            InitializeComponent();
            PopulateTreeView();
            modificarProveedor = new CargarProveedores();

        }

        public void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../../Resources/Carpetas de Proveedores");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }
        public void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        string leerLinea;
        string[] separarDatos;
        private bool grillaCreada = false;



        /*
        private void btnNuevaCarpeta_Click(object sender, EventArgs e)
        {

            //string ruta = lblEjemplo.Text;

            VentanaCarpeta.ShowDialog();

            lblEjemplo.Text = VentanaCarpeta.SelectedPath;
            //seleccionar carpeta

            //treeView1.Nodes.Add

        }
        */

        private void VerArchivos_Load(object sender, EventArgs e)
        {

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal();
            paginaPrincipal.Show();
            this.Close();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!grillaCreada)
            {
                // Leemos el archivo de texto y creamos la grilla
                StreamReader sr = new StreamReader("../../Resources/Carpetas de Proveedores/Datos Proveedores/ListadoAseguradores.csv");
                //El código luego lee la primera línea del archivo de texto. Esta línea contiene los encabezados de las columnas de la grilla.
                string leerLinea;
                string[] separarDatos;

                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');

                for (int indice = 0; indice < separarDatos.Length; indice++)
                {
                    dataGridView1.Columns.Add(separarDatos[indice], separarDatos[indice]);
                }

                while (sr.EndOfStream == false)
                {
                    leerLinea = sr.ReadLine();
                    separarDatos = leerLinea.Split(';');
                    dataGridView1.Rows.Add(separarDatos);
                }

                sr.Close();

                grillaCreada = true;
            }
            else
            {

            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"),
             new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Actualizamos los datos de la grilla
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            StreamReader sr = new StreamReader("../../Resources/Carpetas de Proveedores/Datos Proveedores/ListadoAseguradores.csv");

            string leerLinea;
            string[] separarDatos;

            leerLinea = sr.ReadLine();
            separarDatos = leerLinea.Split(';');

            for (int indice = 0; indice < separarDatos.Length; indice++)
            {
                dataGridView1.Columns.Add(separarDatos[indice], separarDatos[indice]);
            }

            while (sr.EndOfStream == false)
            {
                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');
                dataGridView1.Rows.Add(separarDatos);

            }

            sr.Close();

            MessageBox.Show("Grilla Actualizada");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static int pos;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            pos = 1 + dataGridView1.CurrentRow.Index;

            modificarProveedor.lblModificarNumProveedor.Text = dataGridView1[0, pos - 1].Value.ToString();
            modificarProveedor.txtModificarEntidad.Text = dataGridView1[1, pos].Value.ToString();
            modificarProveedor.txtModificarApertura.Text = dataGridView1[2, pos].Value.ToString();
            modificarProveedor.txtModificarExpediente.Text = dataGridView1[3, pos].Value.ToString();
            modificarProveedor.txtModificarJuzgado.Text = dataGridView1[4, pos].Value.ToString();
            modificarProveedor.txtModificarJurisdiccion.Text = dataGridView1[5, pos].Value.ToString();
            modificarProveedor.txtModificarDireccion.Text = dataGridView1[6, pos].Value.ToString();
            modificarProveedor.txtModificarLiquidador.Text = dataGridView1[7, pos].Value.ToString();

            this.Hide();
            modificarProveedor.Show();


        }
    }
}
