using System.Collections.Generic;
using System.Threading.Tasks;
using ViniMarkert.Core.ApiClient;
using ViniMarkert.Core.Model;

namespace ViniMarkert.Core.Service
{
    public class PromocaoService
    {
        private PromocaoRESTClient _restClient;

        public PromocaoService()
        {
            _restClient = new PromocaoRESTClient();
        }

        public Task<IList<Promocao>> ObterPromocoes()
        {
            return _restClient.ObterPromocoes();
        }
    }
}
