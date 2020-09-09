using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02TeoriaWforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmClickHere_Click(object sender, EventArgs e)
        {
            lblHW.Text = "Patrick Romão Hernandez";
            lblCursoCampus.Text = "ADS - UNIP Anchieta";
            lblSemestre.Text = "3º Semestre";
        }
    }
}
