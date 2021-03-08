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
    public partial class Editar : Form
    {
        public string cpfInicial, renavamInicial;
        public Editar()
        {
            InitializeComponent();
            radioPossuiCarroNao.Checked = true;

            gBoxEditarPessoa.Visible = true;
            gBoxEditarCarro.Visible = false;

        }

        private void radioBtnPessoa_CheckedChanged(object sender, EventArgs e)
        {
            gBoxEditarCarro.Visible = false;
            gBoxEditarPessoa.Visible = true;

            lblBuscarRenavam.Visible = false;
            maskBuscarRenavam.Visible = false;

            lblBuscarCpf.Visible = true;
            maskBuscarCpf.Visible = true;
        }

        private void radioBtnCarro_CheckedChanged(object sender, EventArgs e)
        {
            gBoxEditarPessoa.Visible = false;
            gBoxEditarCarro.Visible = true;            

            lblBuscarCpf.Visible = false;
            maskBuscarCpf.Visible = false;

            lblBuscarRenavam.Visible = true;
            maskBuscarRenavam.Visible = true;
        }

        private void radioPossuiCarroSim_CheckedChanged(object sender, EventArgs e)
        {
            lblEditarPessoaRenavam.Visible = true;
            maskEditarPessoaRenavam.Visible = true;
        }

        private void radioPossuiCarroNao_CheckedChanged(object sender, EventArgs e)
        {
            lblEditarPessoaRenavam.Visible = false;
            maskEditarPessoaRenavam.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(radioBtnCarro.Checked == true)
            {
                renavamInicial = maskBuscarRenavam.Text;
            }
            else if(radioBtnPessoa.Checked == true)
            {
                cpfInicial = maskBuscarCpf.Text;
            }           

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvarCarro_Click(object sender, EventArgs e)
        {
            Carro CarroUpdate = new Carro();
            CarroUpdate.Renavam = maskEditarCarroRenavam.Text;
            CarroUpdate.Modelo = txtEditarCarroModelo.Text;

            CarroUpdate.UpdateCarro(CarroUpdate.Modelo, CarroUpdate.Renavam, maskBuscarRenavam.Text);
        }

        private void btnSalvarPessoa_Click(object sender, EventArgs e)
        {
            Pessoa atualizaPessoa = new Pessoa();
            {
                atualizaPessoa.Cpf = maskEditarPessoaCpf.Text;
                atualizaPessoa.Nome = txtEditarPessoaNome.Text;
                atualizaPessoa.CarroRenavam = maskEditarPessoaRenavam.Text;                

            }

            if (radioPossuiCarroSim.Checked == true)
            {
                atualizaPessoa.UpdatePessoa(maskBuscarCpf.Text, atualizaPessoa.Cpf, atualizaPessoa.Nome, 's', atualizaPessoa.CarroRenavam);
            }
            else if (radioPossuiCarroNao.Checked == true)
            {
                atualizaPessoa.UpdatePessoa(maskBuscarCpf.Text, atualizaPessoa.Cpf, atualizaPessoa.Nome, 'n', "");
            }
            
        }
    }
}
