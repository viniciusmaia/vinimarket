using System.Collections.Generic;
using System.Threading.Tasks;
using ViniMarkert.Core.Model;
using ViniMarket.Core.ApiClient.Base;

namespace ViniMarkert.Core.ApiClient
{
    public class PromocaoRESTClient : RESTClient
    {
        private string _url;

        public PromocaoRESTClient()
        {
            _url = "https://pastebin.com/raw/R9cJFBtG";
        }

        public Task<IList<Promocao>> ObterPromocoes()
        {
            return ObterItens<Promocao>(_url);
        }
    }
}
