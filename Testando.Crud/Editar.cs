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
        public Editar()
        {
            InitializeComponent();
            radioPossuiCarroNao.Checked = true;

            gBoxEditarPessoa.Visible = false;
            gBoxEditarCarro.Visible = false;

            if (radioBtnPessoa.Checked == true)
            {
                gBoxEditarCarro.Visible = false;
                gBoxEditarPessoa.Visible = true;
            }
            else if (radioBtnCarro.Checked == true)
            {
                gBoxEditarPessoa.Visible = false;
                gBoxEditarCarro.Visible = true;
            }
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

            var renavam = maskBuscarRenavam.Text.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
