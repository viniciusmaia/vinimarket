using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ViniMarkert.Core.Model;
using ViniMarket.Core.ApiClient.Base;

namespace ViniMarkert.Core.ApiClient
{
    public class ProdutoRESTClient : RESTClient
    {
        private string _url;

        public ProdutoRESTClient()
        {
            _url = "https://pastebin.com/raw/eVqp7pfX";
        }

        public Task<IList<Produto>> ObterProdutos()
        {
            return ObterItens<Produto>(_url);
        }
    }
}
