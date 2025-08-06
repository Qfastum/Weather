using Newtonsoft.Json;

namespace GismetioClient.Contracts
{
    public class SpeedWindContract
    {
        [JsonProperty("m_s")]
        public float WindSpeed {  get; set; }
    }
}
