using PagamentoAgil.Net.Interfaces;
using PagamentoAgil.Net.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoAgil.Net
{
    public class Cobranca: ICobranca
    {
       
        public string Gerar(Guid conta_token, Guid cedente_token, string url
            , string cliente_nome, string cliente_cpfcnpj, string cliente_email, decimal valor) 
        {
            Fatura f = new Fatura()
            {
                cedente_token = cedente_token.ToString(),
                token = conta_token.ToString(),
                cliente_cpfcnpj = cliente_cpfcnpj,
                cliente_email = cliente_email,
                cliente_nome = cliente_nome,
                valor = String.Format("{0:2N}", valor)
            };

            PostGenericClass p = new PostGenericClass(url);
            string resul = string.Empty;
            p.Post<Fatura>(f, ref resul);
            return resul;

        }

      

    }
}
