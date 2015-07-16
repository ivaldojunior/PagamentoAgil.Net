using PagamentoAgil.Net.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoAgil.Net.Interfaces
{
    public  interface ICobranca
    {
        /// <summary>
        /// Forma mais simples de gerar uma cobrança, o retorno é um array onde possuirá a url e o código da cobrança.
        /// </summary>
        /// <param name="cliente_nome">Nome do cliente</param>
        /// <param name="cliente_cpfcnpj">CPF ou CNPJ sem formatação</param>
        /// <param name="cliente_email">E-mail do cliente</param>
        /// <param name="valor">valor</param>
        /// <returns></returns>
        string[] Gerar(string cliente_nome, string cliente_cpfcnpj
            , string cliente_email, decimal valor);

        /// <summary>
        /// Gere uma cobrança passando o objeto Fatura , o retorno é um array onde possuirá a url e o código da cobrança.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        string[] Gerar(Fatura fatura);


    }
}
