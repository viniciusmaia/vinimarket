using Newtonsoft.Json;

namespace ViniMarkert.Core.Model
{
    public class Categoria
    {
        [JsonProperty("name")]
        public string Nome { get; set; }
    }
}
