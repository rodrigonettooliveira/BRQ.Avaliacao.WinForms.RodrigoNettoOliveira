using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRQ.Avaliacao.DAO.RodrigoNettoOliveira
{
    public class ImportarDadosSqlBulkCopy
    {
        private DataTable dttArquivo;
        private string nomeTabela;
        private string strConexao;

        public ImportarDadosSqlBulkCopy(DataTable _dttArquivo, string _nomeTabela)
        {
            dttArquivo = _dttArquivo;
            nomeTabela = _nomeTabela;
            strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public bool ExecutarSqlBulkCopy()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConexao))
                {
                    conn.Open();

                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                    {
                        sqlBulkCopy.DestinationTableName = nomeTabela;
                        sqlBulkCopy.BatchSize = dttArquivo.Rows.Count;
                        sqlBulkCopy.WriteToServer(dttArquivo);
                    }

                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }       
        }
    }
}
