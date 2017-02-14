namespace wavToMp3
{
    partial class frmPrincipal
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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.tbRuta = new System.Windows.Forms.TextBox();
            this.btnExaminarCarpeta = new System.Windows.Forms.Button();
            this.btnCarpetaDesti = new System.Windows.Forms.Button();
            this.tbDesti = new System.Windows.Forms.TextBox();
            this.lblInformer = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDesti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(439, 184);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(103, 32);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // tbRuta
            // 
            this.tbRuta.Location = new System.Drawing.Point(26, 72);
            this.tbRuta.Name = "tbRuta";
            this.tbRuta.Size = new System.Drawing.Size(393, 20);
            this.tbRuta.TabIndex = 1;
            // 
            // btnExaminarCarpeta
            // 
            this.btnExaminarCarpeta.Location = new System.Drawing.Point(439, 64);
            this.btnExaminarCarpeta.Name = "btnExaminarCarpeta";
            this.btnExaminarCarpeta.Size = new System.Drawing.Size(103, 34);
            this.btnExaminarCarpeta.TabIndex = 2;
            this.btnExaminarCarpeta.Text = "Examinar Carpeta";
            this.btnExaminarCarpeta.UseVisualStyleBackColor = true;
            this.btnExaminarCarpeta.Click += new System.EventHandler(this.btnExaminarCarpeta_Click);
            // 
            // btnCarpetaDesti
            // 
            this.btnCarpetaDesti.Location = new System.Drawing.Point(439, 128);
            this.btnCarpetaDesti.Name = "btnCarpetaDesti";
            this.btnCarpetaDesti.Size = new System.Drawing.Size(103, 34);
            this.btnCarpetaDesti.TabIndex = 3;
            this.btnCarpetaDesti.Text = "Examinar Carpeta";
            this.btnCarpetaDesti.UseVisualStyleBackColor = true;
            this.btnCarpetaDesti.Click += new System.EventHandler(this.btnCarpetaDesti_Click);
            // 
            // tbDesti
            // 
            this.tbDesti.Location = new System.Drawing.Point(26, 136);
            this.tbDesti.Name = "tbDesti";
            this.tbDesti.Size = new System.Drawing.Size(393, 20);
            this.tbDesti.TabIndex = 4;
            // 
            // lblInformer
            // 
            this.lblInformer.AutoSize = true;
            this.lblInformer.Location = new System.Drawing.Point(23, 239);
            this.lblInformer.Name = "lblInformer";
            this.lblInformer.Size = new System.Drawing.Size(44, 13);
            this.lblInformer.TabIndex = 5;
            this.lblInformer.Text = "fdsdfsdf";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(23, 56);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(147, 13);
            this.lblOrigen.TabIndex = 6;
            this.lblOrigen.Text = "Selecciona la carpeta Origen:";
            // 
            // lblDesti
            // 
            this.lblDesti.AutoSize = true;
            this.lblDesti.Location = new System.Drawing.Point(23, 120);
            this.lblDesti.Name = "lblDesti";
            this.lblDesti.Size = new System.Drawing.Size(142, 13);
            this.lblDesti.TabIndex = 7;
            this.lblDesti.Text = "Selecciona la carpeta Destí:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 261);
            this.Controls.Add(this.lblDesti);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblInformer);
            this.Controls.Add(this.tbDesti);
            this.Controls.Add(this.btnCarpetaDesti);
            this.Controls.Add(this.btnExaminarCarpeta);
            this.Controls.Add(this.tbRuta);
            this.Controls.Add(this.btnConvertir);
            this.Name = "frmPrincipal";
            this.Text = "WAV to MP3";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox tbRuta;
        private System.Windows.Forms.Button btnExaminarCarpeta;
        private System.Windows.Forms.Button btnCarpetaDesti;
        private System.Windows.Forms.TextBox tbDesti;
        private System.Windows.Forms.Label lblInformer;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDesti;
    }
}

