using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ViniMarkert.Core.Model;
using ViniMarket.Core.ApiClient.Base;

namespace ViniMarkert.Core.ApiClient
{
    public class CategoriaRESTClient : RESTClient
    {
        private string _url;

        public CategoriaRESTClient()
        {
            _url = "http://pastebin.com/raw/YNR2rsWe";
        }

        public Task<IList<Categoria>> ObterCategorias()
        {
            return ObterItens<Categoria>(_url);
        }
    }
}
