using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testando.Crud
{
    public class Pessoa
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public char Carro { get; set; }
        public string CarroRenavam { get; set; }

        Db db = new Db();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public void AddPessoa(String cpf, String nome, char carro, String carrorenavam)
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


        public void UpdatePessoa(String cpfInicial, String cpf, String nome, char carro, String carrorenavam)
        {
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


        public Pessoa ProcuraPessoa(String cpf)
        {
            {
                cmd.CommandText = @"SELECT * FROM Pessoa WHERE Cpf=@Cpf";

                cmd.Parameters.AddWithValue("@Cpf", cpf);

                try
                {
                    cmd.Connection = db.conectar(); //Conectando com o banco                               

                    SqlDataReader dbResult = cmd.ExecuteReader();   //Executa o comando    

                    return ResultadoProcuraPessoa(dbResult);
                }
                catch (SqlException e)
                {
                    this.mensagem = "Erro ao se conectar com o banco de dados" + e;
                    throw;
                }
            }
        }


        public Pessoa ResultadoProcuraPessoa(SqlDataReader dataReader)
        {
            Pessoa person = new Pessoa();
            int index = 0;

            if (dataReader.Read())
            {
                person.Cpf = dataReader.GetString(index++);
                person.Nome = dataReader.GetString(index++);
                person.Carro = Convert.ToChar(dataReader.GetString(index++));
                person.CarroRenavam = dataReader.GetString(index++);
            }
            this.Nome = person.Nome;
            this.Cpf = person.Cpf;
            this.Carro = person.Carro;
            this.CarroRenavam = person.CarroRenavam;

            return person;
        }


        public void DeletaPessoa(String cpf)
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
