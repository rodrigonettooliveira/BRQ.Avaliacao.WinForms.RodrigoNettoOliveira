using BRQ.Avaliacao.DAO.RodrigoNettoOliveira;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRQ.Avaliacao.Business.RodrigoNettoOliveira
{
    public class GerarArquivo
    {
        private string _nome;

        public GerarArquivo(string nome)
        {
            _nome = nome;
        }

        public void CriarArquivoTxt()
        {
            var dados = new Consultas().ConsultarDados();

            string path = string.Concat(_nome);

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach (var item in dados)
                    {
                        sw.WriteLine(string.Concat(item.NOME, ";", item.ENDERECO, ";", item.BAIRRO, ";", 
                                                   item.CIDADE, ";", item.ESTADO, ";", item.SEXO, ";", 
                                                   item.DATANASCIMENTO));
                    }
                }
            }

        }
    }
}
