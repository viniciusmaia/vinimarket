using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ViniMarket.Core.ApiClient.Base
{
    public abstract class RESTClient
    {

        protected async Task<IList<T>> ObterItens<T>(string url)
        {
            HttpResponseMessage responseMessage = await ExecutaRequisicaoGet(url);

            if (responseMessage.IsSuccessStatusCode)
            {
                var itens = await DeserializaObjeto<IList<T>>(responseMessage);

                return itens;
            }
            else
            {
                throw new Exception("Falha ao obter itens.");
            }
        }

        private async Task<HttpResponseMessage> ExecutaRequisicaoGet(string url)
        {
            using (var cliente = new HttpClient())
            {
                return await cliente.GetAsync(url);
            }
        }

        private async Task<T> DeserializaObjeto<T>(HttpResponseMessage response)
        {
            string json = await response.Content.ReadAsStringAsync();

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            return JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = Formatting.Indented
            });
        }
    }
}