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
                renavamInicial = maskBuscarRenavam.Text;//Guarda o Renavam inicial buscado

                Carro carro = new Carro(); //Cria instancia carro
                carro.Renavam = maskBuscarRenavam.Text; //Carrega instancia carro

                carro.ProcuraCarro(carro.Renavam); //Executa metodo de busca

                //Atualiza campos para fazer o update                
                txtEditarCarroModelo.Text = carro.Modelo;
                maskEditarCarroRenavam.Text = carro.Renavam;
            }
            else if(radioBtnPessoa.Checked == true)
            {
                cpfInicial = maskBuscarCpf.Text; // Guarda o Cpf inicial buscado

                Pessoa pessoa = new Pessoa(); //Cria instancia pessoa
                pessoa.Cpf = maskBuscarCpf.Text; //Carrega instancia pessoa

                pessoa.ProcuraPessoa(pessoa.Cpf); //Executa metodo de busca

                //Atualiza campos para fazer o update
                if(pessoa.Carro == 's')
                {
                    txtEditarPessoaNome.Text = pessoa.Nome;
                    maskEditarPessoaCpf.Text = pessoa.Cpf;
                    radioPossuiCarroSim.Checked = true;
                    maskEditarPessoaRenavam.Text = pessoa.CarroRenavam;
                }
                else if(pessoa.Carro == 'n')
                {
                    txtEditarPessoaNome.Text = pessoa.Nome;
                    maskEditarPessoaCpf.Text = pessoa.Cpf;
                    radioPossuiCarroNao.Checked = true;
                }
                
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

            //CarroUpdate.UpdateCarro(CarroUpdate.Modelo, CarroUpdate.Renavam, renavamInicial);

            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja ATUALIZAR o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                //Excluir
                CarroUpdate.UpdateCarro(CarroUpdate.Modelo, CarroUpdate.Renavam, renavamInicial);

                //Confirmando exclusão para o usuário
                MessageBox.Show("Registro atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                maskBuscarCpf.Text = CarroUpdate.Renavam;
            }
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
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja ATUALIZAR o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    //Excluir
                    atualizaPessoa.UpdatePessoa(maskBuscarCpf.Text, atualizaPessoa.Cpf, atualizaPessoa.Nome, 's', atualizaPessoa.CarroRenavam);

                    //Confirmando exclusão para o usuário
                    MessageBox.Show("Registro atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    maskBuscarCpf.Text = atualizaPessoa.Cpf;

                }
                
            }
            else if (radioPossuiCarroNao.Checked == true)
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja ATUALIZAR o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    //Excluir
                    atualizaPessoa.UpdatePessoa(maskBuscarCpf.Text, atualizaPessoa.Cpf, atualizaPessoa.Nome, 'n', "");

                    //Confirmando exclusão para o usuário
                    MessageBox.Show("Registro atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    maskBuscarCpf.Text = atualizaPessoa.Cpf;
                }                
            }
            
        }
    }
}
