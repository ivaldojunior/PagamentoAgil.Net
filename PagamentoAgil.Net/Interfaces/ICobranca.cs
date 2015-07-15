using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoAgil.Net.Interfaces
{
    public  interface ICobranca
    {
        string Gerar(Guid conta_token, Guid cedente_token, string url
            , string cliente_nome, string cliente_cpfcnpj
            , string cliente_email, decimal valor);


    }
}
