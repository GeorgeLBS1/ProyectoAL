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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ImagenOriginalPTB.ImageLocation = GlobalData.RutaImagen; //ESTABLECER LA IMAGEN ORIGINAL EN EL PICTUREBOX
            Bitmap ImagenFinal;

            Matrices m = new Matrices();
            //var f = m.GetBitMapColorMatrix(GlobalData.RutaImagen);
            Bitmap bitmap = new Bitmap(GlobalData.RutaImagen);
            var gris = m.GrayScaleFilter(bitmap); //Convertir a escala de grises la imagen original
            imgBW.Image = gris; //Mostrar imagen en blanco y negro en el picturebox
            GlobalData.bitmap = gris;
            

        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BTN_Filtro_Click(object sender, EventArgs e)
        {
            int indice = cmbFiltro.SelectedIndex;
            Filtros filtros = new Filtros();
            Matrices m = new Matrices();
            Bitmap Filtrada;
            switch (indice)
            {
                case 0:
                    Filtrada = m.AplicarFiltro(GlobalData.bitmap, filtros.Difuminado);
                    ImagenFiltrada_PTB.Image = Filtrada;
                    break;
                case 1:
                    Filtrada = m.AplicarFiltro(GlobalData.bitmap, filtros.Realzar);
                    ImagenFiltrada_PTB.Image = Filtrada;
                    break;
                case 2:
                    Filtrada = m.AplicarFiltro(GlobalData.bitmap, filtros.SobelInf);
                    ImagenFiltrada_PTB.Image = Filtrada;
                    break;
                case 3:
                    Filtrada = m.AplicarFiltro(GlobalData.bitmap, filtros.SobelSup);
                    ImagenFiltrada_PTB.Image = Filtrada;
                    break;
                case 4:
                    Filtrada = m.AplicarFiltro(GlobalData.bitmap, filtros.SobelIzq);
                    ImagenFiltrada_PTB.Image = Filtrada;
                    break;
                case 5:
                    Filtrada = m.AplicarFiltro(GlobalData.bitmap, filtros.SobelDer);
                    ImagenFiltrada_PTB.Image = Filtrada;
                    break;
                case 6:
                    Filtrada = m.AplicarFiltro(GlobalData.bitmap, filtros.Contorno);
                    ImagenFiltrada_PTB.Image = Filtrada;
                    break;
                case 7:
                    Filtrada = m.AplicarFiltro(GlobalData.bitmap, filtros.Afilar);
                    ImagenFiltrada_PTB.Image = Filtrada;
                    break;
                case 8:
                    Filtrada = m.AplicarFiltro(GlobalData.bitmap, filtros.Original);
                    ImagenFiltrada_PTB.Image = Filtrada;
                    break;
                case 9:
                    
                    if (GlobalData.Personalizado == false)
                    {
                        MessageBox.Show("Asegurese de haber definido un filtro personalizado previamente, de lo contrario no se mostrará nada");
                        break;
                    }
                    else
                    {
                        Filtrada = m.AplicarFiltro(GlobalData.bitmap, GlobalData.matrizFiltro);
                        ImagenFiltrada_PTB.Image = Filtrada;
                    }
                    break;

                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FPersonalizado f2 = new FPersonalizado();
            f2.Show();
            this.Hide();
        }

    }

}
