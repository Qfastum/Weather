namespace WeatherAPI.Configurations
{
    public class CorsSettings : ICorsSettings
    {
        public string[] Cors { get; set; }

        public CorsSettings(IConfiguration configuration) 
        {
            Cors = configuration.GetSection("AllowedOrigins").Get<string[]>();
        }
    }
}
