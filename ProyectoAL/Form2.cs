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

            

            Matrices m = new Matrices();
            //var f = m.GetBitMapColorMatrix(GlobalData.RutaImagen);
            Bitmap bitmap = new Bitmap(GlobalData.RutaImagen);
            var gris = m.GrayScaleFilter(bitmap); //Convertir a escala de grises la imagen original
            var matr = m.ImageTo2DByteArray(gris); //CONVERTIR A UN ARRAY 2D la imagen en blanco y negro
            imgBW.Image = gris; //Mostrar imagen en blanco y negro en el picturebox

        }
        
    }

}
