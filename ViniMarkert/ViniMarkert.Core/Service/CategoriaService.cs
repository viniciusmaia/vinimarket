using System.Collections.Generic;
using System.Threading.Tasks;
using ViniMarkert.Core.ApiClient;
using ViniMarkert.Core.Model;

namespace ViniMarkert.Core.Service
{
    public class CategoriaService
    {
        private CategoriaRESTClient _restClient;

        public CategoriaService()
        {
            _restClient = new CategoriaRESTClient();
        }

        public Task<IList<Categoria>> ObterCategorias()
        {
            return _restClient.ObterCategorias();
        }
    }
}
