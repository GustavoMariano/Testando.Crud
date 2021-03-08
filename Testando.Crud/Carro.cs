using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testando.Crud
{
    public class AddCarro
    {
        Db db = new Db();
        public SqlCommand cmd = new SqlCommand();
        public String mensagem = "";


        public AddCarro(String modelo, String renavam)
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
    }

    public class UpdateCarro
    {
        Db db = new Db();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public UpdateCarro(String modelo, String renavam, String RenavamInicial)
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

                this.mensagem = "Deletado com sucesso!!"; //Mensagem de sucesso
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados" + e;
                throw;
            }

        }
    }

    public class ProcuraCarro
    {
         Db db = new Db();
         public SqlCommand cmd = new SqlCommand();
         public String mensagem = "";
         public SqlDataReader dr;

         public ProcuraCarro(String renavam)
         {
            cmd.CommandText = "select modelo from carro Where Renavam='@renavam'";

            cmd.Parameters.AddWithValue("@Renavam", renavam);

            try
            {
                cmd.Connection = db.conectar(); //Conectando com o banco                               

                dr = cmd.ExecuteReader();    //(System.Data.CommandBehavior.KeyInfo);      //Executa o comando    

                while (dr.Read())
                {
                    MessageBox.Show(dr.GetString(0));
                }

                db.desconectar(); //Desconecta do banco
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados" + e;
                throw;
            }
        }
    }

     public class DeletaCarro
     {
         Db db = new Db();
         SqlCommand cmd = new SqlCommand();
         public String mensagem = "";

         public DeletaCarro(String renavam)
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
