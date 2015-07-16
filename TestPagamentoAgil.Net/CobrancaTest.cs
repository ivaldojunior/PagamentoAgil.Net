using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagamentoAgil.Net;

namespace TestPagamentoAgil.Net
{
    [TestClass]
    public class CobrancaTest
    {
        Guid token { get; set; }

        Guid tokenCedente { get; set; }
 
        [TestMethod]
        public void TestMethodGerar1()
        {
            Cobranca c = new Cobranca(token, tokenCedente);
            var resul = c.Gerar("José", "77567430673", "email@email.com.br", 3m);

        }


    }
}
