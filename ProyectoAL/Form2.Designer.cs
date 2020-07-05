namespace ProyectoAL
{
    partial class Form2
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
            this.ImagenOriginalPTB = new System.Windows.Forms.PictureBox();
            this.BTN_Filtro = new System.Windows.Forms.Button();
            this.ImagenFiltrada_PTB = new System.Windows.Forms.PictureBox();
            this.imgBW = new System.Windows.Forms.PictureBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenOriginalPTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFiltrada_PTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBW)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagenOriginalPTB
            // 
            this.ImagenOriginalPTB.Location = new System.Drawing.Point(46, 89);
            this.ImagenOriginalPTB.Name = "ImagenOriginalPTB";
            this.ImagenOriginalPTB.Size = new System.Drawing.Size(317, 296);
            this.ImagenOriginalPTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenOriginalPTB.TabIndex = 0;
            this.ImagenOriginalPTB.TabStop = false;
            // 
            // BTN_Filtro
            // 
            this.BTN_Filtro.Location = new System.Drawing.Point(507, 431);
            this.BTN_Filtro.Name = "BTN_Filtro";
            this.BTN_Filtro.Size = new System.Drawing.Size(75, 23);
            this.BTN_Filtro.TabIndex = 2;
            this.BTN_Filtro.Text = "Aplicar";
            this.BTN_Filtro.UseVisualStyleBackColor = true;
            this.BTN_Filtro.Click += new System.EventHandler(this.BTN_Filtro_Click);
            // 
            // ImagenFiltrada_PTB
            // 
            this.ImagenFiltrada_PTB.Location = new System.Drawing.Point(704, 254);
            this.ImagenFiltrada_PTB.Name = "ImagenFiltrada_PTB";
            this.ImagenFiltrada_PTB.Size = new System.Drawing.Size(317, 296);
            this.ImagenFiltrada_PTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenFiltrada_PTB.TabIndex = 3;
            this.ImagenFiltrada_PTB.TabStop = false;
            // 
            // imgBW
            // 
            this.imgBW.Location = new System.Drawing.Point(46, 440);
            this.imgBW.Name = "imgBW";
            this.imgBW.Size = new System.Drawing.Size(317, 296);
            this.imgBW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBW.TabIndex = 4;
            this.imgBW.TabStop = false;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "DIFUMINADO",
            "REALZAR",
            "SOBEL INFERIOR",
            "SOBEL SUPERIOR",
            "SOBEL IZQUIERDO",
            "SOBEL DERECHO",
            "CONTORNO",
            "AFILAR",
            "ORIGINAL",
            "PERSONALIZADO"});
            this.cmbFiltro.Location = new System.Drawing.Point(466, 385);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(156, 21);
            this.cmbFiltro.TabIndex = 5;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Filtro Personalizado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 798);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.imgBW);
            this.Controls.Add(this.ImagenFiltrada_PTB);
            this.Controls.Add(this.BTN_Filtro);
            this.Controls.Add(this.ImagenOriginalPTB);
            this.Name = "Form2";
            this.Text = "Filtros";
            ((System.ComponentModel.ISupportInitialize)(this.ImagenOriginalPTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFiltrada_PTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenOriginalPTB;
        private System.Windows.Forms.Button BTN_Filtro;
        private System.Windows.Forms.PictureBox ImagenFiltrada_PTB;
        private System.Windows.Forms.PictureBox imgBW;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Button button1;
    }
}