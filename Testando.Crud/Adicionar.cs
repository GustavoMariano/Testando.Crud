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
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
            gBoxPossuiCarroPessoa.Visible = false;
        }

        private void radioBtnCarro_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnCarroSim.Checked = false;
            radioBtnCarroNao.Checked = false;
            gBoxPossuiCarroPessoa.Visible = false;

            gBoxPessoa.Visible = false;
            gBoxCarro.Visible = true;
        }

        private void radioBtnPessoa_CheckedChanged(object sender, EventArgs e)
        {            
            gBoxCarro.Visible = false;
            gBoxPessoa.Visible = true;
        }

        private void radioBtnSimCarro_CheckedChanged(object sender, EventArgs e)
        {
            gBoxPossuiCarroPessoa.Visible = true;
        }

        private void radioButtonCarroNao_CheckedChanged(object sender, EventArgs e)
        {
            gBoxPossuiCarroPessoa.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(radioBtnCarro.Checked == true)
            {
                MessageBox.Show("Carro selecionado");
            }
            else if(radioBtnPessoa.Checked == true)
            {
                MessageBox.Show("Pessoa selecionada");
            }
        }
    }
}
