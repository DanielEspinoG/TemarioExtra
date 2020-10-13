using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BBotón1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TCuadroTexto1.Text);

        }

        private void BBotón2_Click(object sender, EventArgs e)
        {
            BackColor = Color.CadetBlue;
        }

        private void BBoton3_Click(object sender, EventArgs e)
        {
            TCuadroTexto1.ForeColor = Color.Red;
        }
    }
}
