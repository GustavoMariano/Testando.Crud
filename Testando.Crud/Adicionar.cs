using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            radioBtnCarroNao.Checked = true;
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
            if (radioBtnPessoa.Checked == true)
            {
                char possuiCarro = 'n';
                if (radioBtnCarroSim.Checked == true)
                {
                    possuiCarro = 's';
                    AddPessoa addPessoa = new AddPessoa(maskCpfPessoa.Text, txtNomePessoa.Text, possuiCarro, maskPessoaCarroRenavam.Text);
                }
                else
                {
                    AddPessoa addPessoa = new AddPessoa(maskCpfPessoa.Text, txtNomePessoa.Text, possuiCarro, "");
                }
                

                txtNomePessoa.Text = "";
                maskCpfPessoa.Text = "";
                radioBtnCarroNao.Checked = true;
            }
            else if (radioBtnCarro.Checked == true)
            {
                AddCarro adicionarCarro = new AddCarro(txtModelo.Text, maskRenavamCarro.Text);

                txtModelo.Text = "";
                maskRenavamCarro.Text = "";
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
