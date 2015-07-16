using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoAgil.Net.Model
{
    public class Fatura
    {
        /// <summary>
        /// token da conta de acesso 
        /// </summary>
        public string token {get; set;}
        /// <summary>
        /// token do beneficiário ou cedente, acesse a ficha do cedente para obtê-lo
        /// </summary>
        public string cedente_token {get; set;}
        /// <summary>
        /// nome do cliente
        /// </summary>
        public string cliente_nome {get; set;}
        /// <summary>
        /// cpf ou cnpj do cliente, informe sem formatação
        /// </summary>
        public string cliente_cpfcnpj {get; set;}
        /// <summary>
        /// e-mai do cliente
        /// </summary>
        public string cliente_email {get; set;}
        /// <summary>
        /// telefone do cliente
        /// </summary>
        public string cliente_telefone { get; set; }
        /// <summary>
        /// celular do cliente
        /// </summary>
        public string cliente_celular { get; set; }

        /// <summary>
        /// valor da cobrança
        /// </summary>
        public string valor { get; set; }

        /// <summary>
        /// nome fantasia que será mostrado no e-mail
        /// </summary>
        public string cedente_nomefantasia {get; set;}    
     
        /// <summary>
        /// grupo da cobrança
        /// </summary>
        public string grupo {get; set;}

        /// <summary>
        /// campo livre para detalhamento
        /// </summary>
        public string descricao1 {get; set;}
        /// <summary>
        /// campo livre para detalhamento
        /// </summary>

        public string descricao2 {get; set;}
        /// <summary>
        /// campo livre para detalhamento
        /// </summary>

        public string descricao3 {get; set;}
        /// <summary>
        /// campo livre para detalhamento
        /// </summary>

        public string descricao4 {get; set;}

        /// <summary>
        /// vencimento da cobrança
        /// </summary>

        public string data_vencimento { get; set; }





    }
}
