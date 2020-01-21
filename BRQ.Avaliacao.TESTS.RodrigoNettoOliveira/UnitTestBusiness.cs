using System;
using System.IO;
using BRQ.Avaliacao.Business.RodrigoNettoOliveira;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BRQ.Avaliacao.TESTS.RodrigoNettoOliveira
{
    [TestClass]
    public class UnitTestBusiness
    {
        [TestMethod]
        public void GerarArquivo()
        {
            File.Delete("D:/teste.txt");

            new GerarArquivo("D:/teste.txt").CriarArquivoTxt();

            Assert.AreEqual(File.Exists("D:/teste.txt"), true);
        }
    }
}
