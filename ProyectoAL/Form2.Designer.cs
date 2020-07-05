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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ImagenOriginalPTB = new System.Windows.Forms.PictureBox();
            this.BTN_Filtro = new System.Windows.Forms.Button();
            this.ImagenFiltrada_PTB = new System.Windows.Forms.PictureBox();
            this.imgBW = new System.Windows.Forms.PictureBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CerrarBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
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
            this.imgBW.Location = new System.Drawing.Point(46, 459);
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
            "SOBEL IZQUIERDO",
            "SOBEL SUPERIOR",
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Imagen Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Imagen B y N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(699, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filtro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(847, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 27);
            this.label4.TabIndex = 10;
            // 
            // CerrarBTN
            // 
            this.CerrarBTN.BackColor = System.Drawing.Color.Transparent;
            this.CerrarBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CerrarBTN.BackgroundImage")));
            this.CerrarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CerrarBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarBTN.FlatAppearance.BorderSize = 0;
            this.CerrarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarBTN.Location = new System.Drawing.Point(1033, 0);
            this.CerrarBTN.Margin = new System.Windows.Forms.Padding(0);
            this.CerrarBTN.Name = "CerrarBTN";
            this.CerrarBTN.Size = new System.Drawing.Size(32, 31);
            this.CerrarBTN.TabIndex = 14;
            this.CerrarBTN.UseVisualStyleBackColor = false;
            this.CerrarBTN.Click += new System.EventHandler(this.CerrarBTN_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Image = global::ProyectoAL.Properties.Resources.unnamed;
            this.button2.Location = new System.Drawing.Point(840, 658);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 56);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(822, 717);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "cargar otra imagen";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 798);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CerrarBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.imgBW);
            this.Controls.Add(this.ImagenFiltrada_PTB);
            this.Controls.Add(this.BTN_Filtro);
            this.Controls.Add(this.ImagenOriginalPTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Filtros";
            ((System.ComponentModel.ISupportInitialize)(this.ImagenOriginalPTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFiltrada_PTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenOriginalPTB;
        private System.Windows.Forms.Button BTN_Filtro;
        private System.Windows.Forms.PictureBox ImagenFiltrada_PTB;
        private System.Windows.Forms.PictureBox imgBW;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CerrarBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}