using Newtonsoft.Json;

namespace Covid.Models
{
    public class LatestModel
    {
        [JsonProperty("latest")] public Latest Latest { get; set; }
    }
}