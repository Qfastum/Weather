using Newtonsoft.Json;

namespace GismetioClient.Contracts
{
    public class SpeedWindContract
    {
        [JsonProperty("m_s")]
        public int Ms {  get; set; }
    }
}
