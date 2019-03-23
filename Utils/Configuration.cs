using Microsoft.Extensions.Configuration;

namespace DosvitTests
{

    public class Configuration
    {
        public static IConfiguration Settings;

        static Configuration()
        {
            Settings = new ConfigurationBuilder().AddJsonFile("config.json").Build();
        }
    }
}