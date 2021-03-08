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
                Pessoa pessoaNew = new Pessoa();
                pessoaNew.Cpf = maskCpfPessoa.Text;
                pessoaNew.Nome = txtNomePessoa.Text;
                pessoaNew.CarroRenavam = maskPessoaCarroRenavam.Text;


                if (radioBtnCarroSim.Checked == true)
                {
                    pessoaNew.AddPessoa(pessoaNew.Cpf, pessoaNew.Nome, 's', pessoaNew.CarroRenavam );
                    
                }
                else
                {
                    pessoaNew.AddPessoa(pessoaNew.Cpf, pessoaNew.Nome, 'n', "");
                }
                
                //Limpa campos

                txtNomePessoa.Text = "";
                maskCpfPessoa.Text = "";
                radioBtnCarroNao.Checked = true;
            }
            else if (radioBtnCarro.Checked == true)
            {
                Carro carroNew = new Carro();
                carroNew.Renavam = maskRenavamCarro.Text;
                carroNew.Modelo = txtModelo.Text;

                carroNew.AddCarro(carroNew.Modelo, carroNew.Renavam);

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
