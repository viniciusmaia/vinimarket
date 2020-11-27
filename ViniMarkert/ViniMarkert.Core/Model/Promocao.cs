using Newtonsoft.Json;
using System.Collections.Generic;

namespace ViniMarkert.Core.Model
{
    public class Promocao
    {
        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("category_id")]
        public int IdCategoria { get; set; }

        [JsonProperty("policies")]
        public IList<RegraPromocao> Regras { get; set; }
    }
}
