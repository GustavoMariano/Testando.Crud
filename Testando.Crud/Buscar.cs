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
using System.Configuration;


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

            if (radioBtnCarro.Checked == true)
            {
                lblNome.Visible = false;
                lblModelo.Visible = true;
            }
            else if (radioBtnPessoa.Checked == true)
            {
                lblModelo.Visible = false;
                lblNome.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(radioBtnPessoa.Checked == true)
            {
                Pessoa buscaPessoa = new Pessoa();
                buscaPessoa.Cpf = maskBuscarCpf.Text;

                buscaPessoa.ProcuraPessoa(buscaPessoa.Cpf);
            }
            else if(radioBtnCarro.Checked == true)
            {
                Carro selectCarro = new Carro();
                selectCarro.Renavam = maskBuscarRenavam.Text;

                selectCarro.ProcuraCarro(selectCarro.Renavam);
            }            
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }                
    }    
}

