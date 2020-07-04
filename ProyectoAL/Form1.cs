using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoAL.Utilities;

namespace ProyectoAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnalizarGramatica.Enabled = false;
        }

        private void AbrirArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RutaText.Text = openFileDialog1.FileName;
                GlobalData.RutaImagen = openFileDialog1.FileName; //SE GUARDA LA RUTA DE LA IMAGEN EN UNA VARIABLE GLOBAL
                //Verificar que el archivo no sea un archivo en blanco
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                if (file.Length == 0)
                {
                    MessageBox.Show("Archivo no valido, no puede usar un archivo vacío.");
                    RutaText.Text = "";
                }
                else
                {
                    AnalizarGramatica.Enabled = true;
                }

            }
        }

        private void AnalizarGramatica_Click(object sender, EventArgs e)
        {
            
            //Form2 f2 = new Form2();
            //f2.Show();
            //this.Hide();
        }

        private void CerrarBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
