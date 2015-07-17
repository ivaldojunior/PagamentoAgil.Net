using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagamentoAgil.Net;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TestPagamentoAgil.Net
{
    [TestClass]
    public class PostTest
    {
        [TestMethod]
        public void Test1()
        {
            Cobranca c = new Cobranca("token_conta", "cedente_token");
            c.Gerar("Joaquim Lima", "445454555", "email@email", 3m);
        }
    

    }


}
