using BRQ.Avaliacao.DAO.RodrigoNettoOliveira.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace BRQ.Avaliacao.DAO.RodrigoNettoOliveira
{

    public class Consultas
    {
        private string strConexao;

        public Consultas()
        {
            strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        } 

        public List<ArquivoAvaliacao> ConsultarDados()
        {
            var query = @"
                            SELECT 
	                            NOME,
	                            ENDERECO,
	                            BAIRRO,
	                            CIDADE,
	                            ESTADO,
	                            SEXO,
	                            DATANASCIMENTO
                            FROM 
	                            ArquivoTexto ";

            var arquivoList = new List<ArquivoAvaliacao>();

            using (SqlConnection connection = new SqlConnection(strConexao))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var arquivoAvaliacao = new ArquivoAvaliacao();

                        arquivoAvaliacao.NOME = reader["NOME"].ToString();
                        arquivoAvaliacao.ENDERECO = reader["ENDERECO"].ToString();
                        arquivoAvaliacao.BAIRRO = reader["BAIRRO"].ToString();
                        arquivoAvaliacao.CIDADE = reader["CIDADE"].ToString();
                        arquivoAvaliacao.ESTADO = reader["ESTADO"].ToString();
                        arquivoAvaliacao.SEXO = reader["SEXO"].ToString();
                        arquivoAvaliacao.DATANASCIMENTO = reader["DATANASCIMENTO"].ToString();

                        arquivoList.Add(arquivoAvaliacao);
                    }
                    reader.Close();

                    return arquivoList;
                }
                catch (Exception )
                {
                    throw;
                }
            }
        }

    }
}
