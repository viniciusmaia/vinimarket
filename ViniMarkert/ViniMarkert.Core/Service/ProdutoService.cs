using System.Collections.Generic;
using System.Threading.Tasks;
using ViniMarkert.Core.ApiClient;
using ViniMarkert.Core.Model;

namespace ViniMarkert.Core.Service
{
    public class ProdutoService
    {
        private ProdutoRESTClient _restClient;

        public ProdutoService()
        {
            _restClient = new ProdutoRESTClient();
        }

        public Task<IList<Produto>> ObterProdutos()
        {
            return _restClient.ObterProdutos();
        }
    }
}
