using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01
{
    public partial class PrimeiraTela : Form
    {
        public PrimeiraTela()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblEntrada_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtEntrada.Text+ "\n"+txtEntrada2.Text);
            lblRecebe.Text = txtEntrada.Text+ "\n"+txtEntrada2.Text;
        }
    }
}
