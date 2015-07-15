﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagamentoAgil.Net;

namespace TestPagamentoAgil.Net
{
    [TestClass]
    public class CobrancaTest
    {

        Guid token
        {
            get
            {
                return Guid.Parse("dddd");
            }
        }

        Guid tokenCedente
        {
            get
            {
                return Guid.Parse("ddddd");
            }
        }

        const string url = "http://www.pagamentoagil.com.br/webservice/GetLink";

        [TestMethod]
        public void TestMethodGerar1()
        {
            Cobranca c = new Cobranca();
            var resul = c.Gerar(token, tokenCedente, url, "José", "77567430673", "email@email.com.br", 3m);

        }


    }
}