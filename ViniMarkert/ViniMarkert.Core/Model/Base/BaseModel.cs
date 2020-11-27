using Newtonsoft.Json;

namespace ViniMarkert.Core.Model.Base
{
    public abstract class BaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
