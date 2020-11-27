using Newtonsoft.Json;
using ViniMarkert.Core.Model.Base;

namespace ViniMarkert.Core.Model
{
    public class Produto : BaseModel
    {
        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("description")]
        public string Descricao { get; set; }

        [JsonProperty("photo")]
        public string UrlFoto { get; set; }

        [JsonProperty("price")]
        public decimal Preco { get; set; }

        [JsonProperty("category_id")]
        public int IdCategoria { get; set; }

        [JsonIgnore]
        public bool Favorito { get; set; }
    }
}
