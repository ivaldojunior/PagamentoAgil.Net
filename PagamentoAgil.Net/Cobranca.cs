using PagamentoAgil.Net.Interfaces;
using PagamentoAgil.Net.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoAgil.Net
{
    /// <summary>
    /// Para usar esta classe você precisará de uma conta no site www.pagamentoagil.com.br
    /// o cadastro é grátis.
    /// </summary>
    public class Cobranca: ICobranca
    {

        Guid _token { get; set; }
        Guid _tokenCedente { get; set; }

        public Cobranca(Guid conta_token, Guid cedente_token)
        {
            _token = conta_token;
            _tokenCedente = cedente_token;
        }

        const string url = "http://www.pagamentoagil.com.br/webservice/GetCodeAndLink";

        /// <summary>
        /// Forma mais simples de gerar uma cobrança, o retorno é um array onde possuirá a url e o código da cobrança.
        /// </summary>
        /// <param name="cliente_nome">Nome do cliente</param>
        /// <param name="cliente_cpfcnpj">CPF ou CNPJ sem formatação</param>
        /// <param name="cliente_email">E-mail do cliente</param>
        /// <param name="valor">valor</param>
        /// <returns></returns>
        public string[] Gerar(string cliente_nome, string cliente_cpfcnpj, string cliente_email, decimal valor) 
        {
            Fatura f = new Fatura()
            {
                cedente_token = _tokenCedente.ToString(),
                token = _token.ToString(),
                cliente_cpfcnpj = cliente_cpfcnpj,
                cliente_email = cliente_email,
                cliente_nome = cliente_nome,
                valor = String.Format("{0:N2}", valor)
            };

            PostGenericClass p = new PostGenericClass(url);
            string resul = string.Empty;
            p.Post<Fatura>(f, ref resul);
            return resul.Split(';');

        }

        /// <summary>
        /// Gere uma cobrança passando o objeto Fatura , o retorno é um array onde possuirá a url e o código da cobrança.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public string[] Gerar(Fatura f)
        {
            PostGenericClass p = new PostGenericClass(url);
            string resul = string.Empty;
            p.Post<Fatura>(f, ref resul);
            return resul.Split(';');
        }


    }
}
