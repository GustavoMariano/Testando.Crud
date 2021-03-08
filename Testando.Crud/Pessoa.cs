﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testando.Crud
{
    public class AddPessoa
    {
        Db db = new Db();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public AddPessoa(String cpf, String nome, char carro, String carrorenavam)
        {
            cmd.CommandText = "insert into Pessoa (Cpf, Nome, Carro, CarroRenavam) VALUES (@Cpf, @Nome, @Carro, @CarroRenavam)";

            cmd.Parameters.AddWithValue("@Cpf", cpf);
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Carro", carro);
            cmd.Parameters.AddWithValue("@CarroRenavam", carrorenavam);

            try
            {
                cmd.Connection = db.conectar(); //Conectando com o banco

                cmd.ExecuteNonQuery(); //Executa o comando

                db.desconectar(); //Desconecta do banco

                MessageBox.Show("Cadastrado com sucesso"); //Mensagem de sucesso
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados" + e;
                throw;
            }
        }
    }

    public class UpdatePessoa
    {
        Db db = new Db();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public UpdatePessoa(String cpfInicial, String cpf, String nome, char carro, String carrorenavam)
        {
            cmd.CommandText = "update Pessoa SET Cpf = @Cpf, Nome = @Nome, Carro = Carro, CarroRenavam = @CarroRenavam Where Cpf = @CpfInicial";

            cmd.Parameters.AddWithValue("CpfInicial", cpfInicial);
            cmd.Parameters.AddWithValue("@Cpf", cpf);
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Carro", carro);
            cmd.Parameters.AddWithValue("@CarroRenavam", carrorenavam);

            try
            {
                cmd.Connection = db.conectar(); //Conectando com o banco

                cmd.ExecuteNonQuery(); //Executa o comando

                db.desconectar(); //Desconecta do banco

                this.mensagem = "Deletado com sucesso!!"; //Mensagem de sucesso
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados" + e;
                throw;
            }
        }
    }

    public class ProcuraPessoa
    {
        Db db = new Db();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public SqlDataReader dr;


        public ProcuraPessoa(String cpf)
        {

        }
    }

    public class DeletaPessoa
    {
        Db db = new Db();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public DeletaPessoa(String cpf)
        {
            cmd.CommandText = "delete from Pessoa Where Cpf=@Cpf";

            cmd.Parameters.AddWithValue("@Cpf", cpf);

            try
            {
                cmd.Connection = db.conectar(); //Conectando com o banco

                cmd.ExecuteNonQuery(); //Executa o comando

                db.desconectar(); //Desconecta do banco

                this.mensagem = "Deletado com sucesso!!"; //Mensagem de sucesso
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados" + e;
                throw;
            }
        }
    }
}
