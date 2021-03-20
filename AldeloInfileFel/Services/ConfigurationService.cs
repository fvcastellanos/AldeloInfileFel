using AldeloInfileFel.Domain;
using Newtonsoft.Json;
using System;
using System.IO;

namespace AldeloInfileFel.Services
{
    public static class ConfigurationService
    {
        public static FelInformation LoadConfiguration()
        {
            var configurationFile = Environment.GetEnvironmentVariable("ADELO_FEL_CONFIGURATION_FILE");
            var configuration = File.ReadAllText(configurationFile);

            return JsonConvert.DeserializeObject<FelInformation>(configuration);
        }
    }
}
