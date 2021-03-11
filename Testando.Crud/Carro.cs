using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testando.Crud
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Renavam { get; set; }

        Db db = new Db();
        public SqlCommand cmd = new SqlCommand();
        public String mensagem = "";


        public void AddCarro(String modelo, String renavam)
        {
        cmd.CommandText = "insert into Carro (Renavam, Modelo) VALUES (@Renavam, @Modelo)";

            cmd.Parameters.AddWithValue("@Renavam", renavam);
            cmd.Parameters.AddWithValue("@Modelo", modelo);

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

        public void UpdateCarro(String modelo, String renavam, String RenavamInicial)
        {
            cmd.CommandText = "update Carro SET Modelo = @Modelo, Renavam = @Renavam Where Renavam = @RenavamInicial";

            cmd.Parameters.AddWithValue("@RenavamInicial", RenavamInicial);
            cmd.Parameters.AddWithValue("@Modelo", modelo);
            cmd.Parameters.AddWithValue("@Renavam", renavam);

            try
            {
                cmd.Connection = db.conectar(); //Conectando com o banco

                cmd.ExecuteNonQuery(); //Executa o comando

                db.desconectar(); //Desconecta do banco

                this.mensagem = "Editado com sucesso!!"; //Mensagem de sucesso
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados" + e;
                throw;
            }

        }

        public Carro ProcuraCarro(String renavam)
        {
            {
                cmd.CommandText = @"SELECT * FROM Carro WHERE Renavam=@Renavam";

                cmd.Parameters.AddWithValue("@Renavam", renavam);

                try
                {
                    cmd.Connection = db.conectar(); //Conectando com o banco                               

                    SqlDataReader dbResult = cmd.ExecuteReader();   //Executa o comando    

                    return ResultadoProcuraCarro(dbResult);
                }
                catch (SqlException e)
                {
                    this.mensagem = "Erro ao se conectar com o banco de dados" + e;
                    throw;
                }
            }
        }


        public Carro ResultadoProcuraCarro(SqlDataReader dataReader)
        {
            Carro car = new Carro();
            int index = 0;

            if (dataReader.Read())
            {
                car.Renavam = dataReader.GetString(index++);
                car.Modelo = dataReader.GetString(index++);
            }
            this.Modelo = car.Modelo;
            this.Renavam = car.Renavam;

            return car;
        }

        public void DeletaCarro(String renavam)
        {

            cmd.CommandText = "delete from Carro Where Renavam=@renavam";

            cmd.Parameters.AddWithValue("@Renavam", renavam);

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

