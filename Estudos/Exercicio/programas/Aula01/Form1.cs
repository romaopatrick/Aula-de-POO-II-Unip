using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01Chacara
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtMensagem.Text);
            
            lblResult.Text = "A mensagem digitada foi:\n"+
                txtMensagem.Text+ "\n"
                +"A cor selecionada foi:"+cmbCores.SelectedItem
                + "\n"+"O idioma escolhido foi:"+
                  (rbPortugues.Checked ? " " + rbPortugues.Text : "") +
                (rbIngles.Checked ? " " + rbIngles.Text : "" + mskCpf.Text);
            

        }

        private void Inicial_Load(object sender, EventArgs e)
        {

        }
    }
}
