using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Configuration;

namespace BRQ.Avaliacao.Data.RodrigoNettoOliveira
{
    public class ImportarDados
    {
        DataTable dttEntrada;
        string strNomeTabela;
        string strCon;
        SqlConnection


        public ImportarDados(DataTable _dttEntrada, string _strNomeTabela, string _strCon)
        {
            dttEntrada = _dttEntrada;
            strNomeTabela = _strNomeTabela;
            strCon = _strCon;    
        }





    }
}
