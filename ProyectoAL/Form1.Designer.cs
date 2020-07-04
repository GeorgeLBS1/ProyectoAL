namespace ProyectoAL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AnalizarGramatica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RutaText = new System.Windows.Forms.TextBox();
            this.AbrirArchivo = new System.Windows.Forms.Button();
            this.CerrarBTN = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // AnalizarGramatica
            // 
            this.AnalizarGramatica.Location = new System.Drawing.Point(225, 142);
            this.AnalizarGramatica.Name = "AnalizarGramatica";
            this.AnalizarGramatica.Size = new System.Drawing.Size(71, 34);
            this.AnalizarGramatica.TabIndex = 7;
            this.AnalizarGramatica.Text = "Cargar";
            this.AnalizarGramatica.UseVisualStyleBackColor = true;
            this.AnalizarGramatica.Click += new System.EventHandler(this.AnalizarGramatica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ruta de la imagen:";
            // 
            // RutaText
            // 
            this.RutaText.Location = new System.Drawing.Point(109, 81);
            this.RutaText.Name = "RutaText";
            this.RutaText.ReadOnly = true;
            this.RutaText.Size = new System.Drawing.Size(302, 20);
            this.RutaText.TabIndex = 5;
            // 
            // AbrirArchivo
            // 
            this.AbrirArchivo.Location = new System.Drawing.Point(435, 78);
            this.AbrirArchivo.Name = "AbrirArchivo";
            this.AbrirArchivo.Size = new System.Drawing.Size(75, 23);
            this.AbrirArchivo.TabIndex = 4;
            this.AbrirArchivo.Text = "Seleccionar";
            this.AbrirArchivo.UseVisualStyleBackColor = true;
            this.AbrirArchivo.Click += new System.EventHandler(this.AbrirArchivo_Click);
            // 
            // CerrarBTN
            // 
            this.CerrarBTN.BackColor = System.Drawing.Color.Transparent;
            this.CerrarBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CerrarBTN.BackgroundImage")));
            this.CerrarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CerrarBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarBTN.FlatAppearance.BorderSize = 0;
            this.CerrarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarBTN.Location = new System.Drawing.Point(493, -2);
            this.CerrarBTN.Margin = new System.Windows.Forms.Padding(0);
            this.CerrarBTN.Name = "CerrarBTN";
            this.CerrarBTN.Size = new System.Drawing.Size(32, 31);
            this.CerrarBTN.TabIndex = 13;
            this.CerrarBTN.UseVisualStyleBackColor = false;
            this.CerrarBTN.Click += new System.EventHandler(this.CerrarBTN_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos.txt(*.jpg)|*.jpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 223);
            this.Controls.Add(this.CerrarBTN);
            this.Controls.Add(this.AnalizarGramatica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RutaText);
            this.Controls.Add(this.AbrirArchivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnalizarGramatica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RutaText;
        private System.Windows.Forms.Button AbrirArchivo;
        private System.Windows.Forms.Button CerrarBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

