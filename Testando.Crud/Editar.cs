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
            UpdateCarro updateCarro = new UpdateCarro(txtEditarCarroModelo.Text, maskEditarCarroRenavam.Text, maskBuscarRenavam.Text);
        }

        private void btnSalvarPessoa_Click(object sender, EventArgs e)
        {
            if (radioPossuiCarroSim.Checked == true)
            {
                UpdatePessoa updatePessoa = new UpdatePessoa(maskBuscarCpf.Text, maskEditarPessoaCpf.Text, txtEditarPessoaNome.Text, 's',maskEditarPessoaRenavam.Text);
            }
            else if (radioPossuiCarroNao.Checked == true)
            {
                UpdatePessoa updatePessoa = new UpdatePessoa(maskBuscarCpf.Text, maskEditarPessoaCpf.Text, txtEditarPessoaNome.Text, 'n', "");
            }
            
        }
    }
}
