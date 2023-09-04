namespace PryPerezIE
{
    partial class VerArchivos
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nodo2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Proveedores", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nodo4");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Aseguradoras", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.btnNuevaCarpeta = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.volverToolStripMenuItem.Text = "volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // btnNuevaCarpeta
            // 
            this.btnNuevaCarpeta.Location = new System.Drawing.Point(12, 27);
            this.btnNuevaCarpeta.Name = "btnNuevaCarpeta";
            this.btnNuevaCarpeta.Size = new System.Drawing.Size(246, 56);
            this.btnNuevaCarpeta.TabIndex = 1;
            this.btnNuevaCarpeta.Text = "Buscar Carpeta";
            this.btnNuevaCarpeta.UseVisualStyleBackColor = true;
            this.btnNuevaCarpeta.Click += new System.EventHandler(this.btnNuevaCarpeta_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(303, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo2";
            treeNode1.Text = "Nodo2";
            treeNode2.Name = "Proveedores";
            treeNode2.Text = "Proveedores";
            treeNode3.Name = "Nodo4";
            treeNode3.Text = "Nodo4";
            treeNode4.Name = "Aseguradoras";
            treeNode4.Text = "Aseguradoras";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(231, 253);
            this.treeView1.TabIndex = 2;
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.AutoSize = true;
            this.lblEjemplo.Location = new System.Drawing.Point(73, 101);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(10, 13);
            this.lblEjemplo.TabIndex = 3;
            this.lblEjemplo.Text = "-";
            // 
            // VerArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnNuevaCarpeta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VerArchivos";
            this.Text = "Ver Archivos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog VentanaCarpeta;
        private System.Windows.Forms.Button btnNuevaCarpeta;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblEjemplo;
    }
}