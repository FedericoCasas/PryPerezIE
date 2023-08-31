namespace PryPerezIE
{
    partial class Logo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logo));
            this.tmProgreso = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmProgreso
            // 
            this.tmProgreso.Enabled = true;
            this.tmProgreso.Interval = 200;
            this.tmProgreso.Tick += new System.EventHandler(this.tmProgreso_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar1.Location = new System.Drawing.Point(12, 454);
            this.progressBar1.Maximum = 101;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(855, 25);
            this.progressBar1.TabIndex = 0;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPorcentaje.Location = new System.Drawing.Point(414, 482);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(34, 20);
            this.lblPorcentaje.TabIndex = 1;
            this.lblPorcentaje.Text = "0%";
            // 
            // Logo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryPerezIE.Properties.Resources.Sin_título;
            this.ClientSize = new System.Drawing.Size(879, 504);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Logo";
            this.Text = "Logo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmProgreso;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPorcentaje;
    }
}

