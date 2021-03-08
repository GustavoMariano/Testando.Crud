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
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void radioBtnPessoa_CheckedChanged(object sender, EventArgs e)
        {
            lblExcluirRenavam.Visible = false;
            maskExcluirRenavam.Visible = false;

            lblExcluirCpf.Visible = true;
            maskExcluirCpf.Visible = true;
        }

        private void radioBtnCarro_CheckedChanged(object sender, EventArgs e)
        {
            lblExcluirCpf.Visible = false;
            maskExcluirCpf.Visible = false;

            lblExcluirRenavam.Visible = true;
            maskExcluirRenavam.Visible = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(radioBtnCarro.Checked == true)
            {
                Carro CarroDelete = new Carro();
                CarroDelete.Renavam = maskExcluirRenavam.Text;
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja APAGAR o registro do Carro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    //Excluir
                    CarroDelete.DeletaCarro(CarroDelete.Renavam);

                    //Confirmando exclusão para o usuário
                    MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else if(radioBtnPessoa.Checked == true)
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja APAGAR o registro da pessoa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    //Excluir
                    Pessoa pessoaDelete = new Pessoa();
                    pessoaDelete.Cpf = maskExcluirCpf.Text;
                    pessoaDelete.DeletaPessoa(pessoaDelete.Cpf);

                    //Confirmando exclusão para o usuário
                    MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
