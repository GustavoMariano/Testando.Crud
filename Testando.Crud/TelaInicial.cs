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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnAddCarro_Click(object sender, EventArgs e)
        {            
            Adicionar tela = new Adicionar();
            tela.Show();
        }

        private void btnBuscarCarro_Click(object sender, EventArgs e)
        {
            Buscar tela = new Buscar();
            tela.Show();
        }

        private void btnEditarCarro_Click(object sender, EventArgs e)
        {
            Editar tela = new Editar();
            tela.Show();
        }

        private void btnExcluirCarro_Click(object sender, EventArgs e)
        {
            Excluir tela = new Excluir();
            tela.Show();
        }
    }
}
