using AldeloInfileFel.Domain;
using Newtonsoft.Json;
using System;
using System.IO;

namespace AldeloInfileFel.Services
{
    public static class ConfigurationService
    {
        public static Configuration LoadConfiguration()
        {
            var configurationFile = Environment.GetEnvironmentVariable("ADELO_FEL_CONFIGURATION_APP_FILE");
            var configuration = File.ReadAllText(configurationFile);

            return JsonConvert.DeserializeObject<Configuration>(configuration);
        }
    }
}
