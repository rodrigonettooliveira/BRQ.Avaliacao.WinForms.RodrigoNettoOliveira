using BRQ.Avaliacao.DAO.RodrigoNettoOliveira;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRQ.Avaliacao.Business.RodrigoNettoOliveira
{
    public class ImportarArquivoBusiness
    {
        private DataTable dttArquivo;
        private string nomeTabela;
        public ImportarArquivoBusiness(DataTable _dttArquivo, string _nomeTabela)
        {
            dttArquivo = _dttArquivo;
            nomeTabela = _nomeTabela;
        }

        public bool Importar()
        {
            try
            {
                ValidarConteudoArquivo();

                return new ImportarDadosSqlBulkCopy(dttArquivo, nomeTabela).ExecutarSqlBulkCopy();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidarConteudoArquivo()
        {
            if (dttArquivo.Rows.Count == 0)
            {
                throw new Exception("Arquivo sem linhas.");
            }

            if (dttArquivo.Columns.Count < 6)
            {
                throw new Exception("Arquivo com menos de 6 colunas não pode ser importado.");
            }

            if (dttArquivo.Rows.Count < 10)
            {
                throw new Exception("Arquivo com menos de 10 linhas não pode ser importado");
            }
        }
    }
}
