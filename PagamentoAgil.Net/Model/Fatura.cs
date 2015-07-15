using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoAgil.Net.Model
{
    public class Fatura
    {
        public string token {get; set;}
        public string cedente_token {get; set;}
        public string cliente_nome {get; set;}
        public string cliente_cpfcnpj {get; set;}
        public string cliente_email {get; set;}
        public string valor { get; set; }
    }
}
