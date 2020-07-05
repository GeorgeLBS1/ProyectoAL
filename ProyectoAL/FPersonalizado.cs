using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoAL.Utilities;

namespace ProyectoAL
{
    public partial class FPersonalizado : Form
    {
        public FPersonalizado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valoresValidos = false;
            if (maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || maskedTextBox3.Text == "" || maskedTextBox4.Text == "" || maskedTextBox5.Text == "" || maskedTextBox6.Text == "" || maskedTextBox7.Text == "" || maskedTextBox8.Text == "" || maskedTextBox9.Text == "")
            {
                valoresValidos = false;
                GlobalData.Personalizado = false;
            }
            else
            {
                valoresValidos = true;
            }
            if (valoresValidos == false)
            {
                MessageBox.Show("Meta valores validos");
                GlobalData.Personalizado = false;
            }
            else
            {
                double t1, t2, t3, t4, t5, t6, t7, t8, t9;
                if (double.TryParse(maskedTextBox1.Text, out t1) == true && double.TryParse(maskedTextBox2.Text, out t2) == true && double.TryParse(maskedTextBox3.Text, out t3) == true && double.TryParse(maskedTextBox4.Text, out t4) == true && double.TryParse(maskedTextBox5.Text, out t5) == true && double.TryParse(maskedTextBox6.Text, out t6) == true && double.TryParse(maskedTextBox7.Text, out t7) == true && double.TryParse(maskedTextBox8.Text, out t8) == true && double.TryParse(maskedTextBox9.Text, out t9) == true)
                {
                    GlobalData.Personalizado = true;
                    Filtros filtros = new Filtros();
                    GlobalData.matrizFiltro = filtros.Personalizado(t1, t2, t3, t4, t5, t6, t7, t8, t9);

                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
            }
        }
    }
}
