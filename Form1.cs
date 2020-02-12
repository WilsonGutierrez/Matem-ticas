using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matemáticas
{
    public partial class Form1 : Form
    {
        estadistica objEstadistica = new estadistica();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Aritmetica_Click(object sender, EventArgs e)
        {
            //Split => Divide una cadena en base a un delimitador (patrón) y devuelve una  matriz
            lblRespuesta.Text = "X= " + objEstadistica.media(txtSerie.Text.Split(','));
        }

        private void btnEstandar_Click(object sender, EventArgs e)
        {
            lblRespuesta.Text = "Tipica= " + objEstadistica.estandar(txtSerie.Text.Split(','));
        }

        private void btnTipica_Click(object sender, EventArgs e)
        {
            lblRespuesta.Text = "X=" + objEstadistica.tipica(txtSerie.Text.Split(','));
        }
    }
}
