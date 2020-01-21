using System;
using System.Data;
using BRQ.Avaliacao.DAO.RodrigoNettoOliveira;
using BRQ.Avaliacao.DAO.RodrigoNettoOliveira.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BRQ.Avaliacao.TESTS.RodrigoNettoOliveira
{
    [TestClass]
    public class UnitTestDao
    {
        [TestMethod]
        public void ExecutarSqlBulkCopy()
        {  
            var dt = new DataTable();
            dt.Columns.Add("NOME");
            dt.Columns.Add("ENDERECO");
            dt.Columns.Add("BAIRRO");
            dt.Columns.Add("CIDADE");
            dt.Columns.Add("ESTADO");
            dt.Columns.Add("SEXO");
            dt.Columns.Add("DATANASCIMENTO");

            for (int i = 0; i < 10; i++)
            {
                DataRow nova = dt.NewRow();
                nova["NOME"] = string.Concat("Nome - ", i);
                nova["ENDERECO"] = string.Concat("ENDERECO - ", i);
                nova["BAIRRO"] = string.Concat("BAIRRO - ", i); 
                nova["CIDADE"] = string.Concat("Cidade - ", i); 
                nova["ESTADO"] = "SP"; 
                nova["SEXO"] = "M";
                nova["DATANASCIMENTO"] = string.Concat("0801198", i);

                dt.Rows.Add(nova);
            }

            var bulkCopy = new ImportarDadosSqlBulkCopy(dt, "ArquivoTexto");

            var retorno = bulkCopy.ExecutarSqlBulkCopy();

            Assert.AreEqual(true, retorno);
        }

        [TestMethod]
        public void ConsultarDados()
        {
            var retorno = new Consultas().ConsultarDados();

            Assert.AreEqual(retorno.Count > 0, true);
        }
    }
}
