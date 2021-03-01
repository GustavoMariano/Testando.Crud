using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testando.Crud
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();

            lblModelo.Visible = false;
        }

        private void radioBtnPessoa_CheckedChanged(object sender, EventArgs e)
        {
            lblBuscarRenavam.Visible = false;
            maskBuscarRenavam.Visible = false;

            lblBuscarCpf.Visible = true;
            maskBuscarCpf.Visible = true;
        }

        private void radioBtnCarro_CheckedChanged(object sender, EventArgs e)
        {            
            lblBuscarCpf.Visible = false;
            maskBuscarCpf.Visible = false;

            lblBuscarRenavam.Visible = true;
            maskBuscarRenavam.Visible = true;

            if(radioBtnCarro.Checked == true)
            {
                lblNome.Visible = false;
                lblModelo.Visible = true;                
            }
            else if(radioBtnPessoa.Checked == true)
            {
                lblModelo.Visible = false;
                lblNome.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (radioBtnPessoa.Checked == true)
            {
                MessageBox.Show("Pessoa selecionada");
            }
            else if (radioBtnCarro.Checked == true)
            {
                MessageBox.Show("Carro selecionado");
            }
        }
    }
}
