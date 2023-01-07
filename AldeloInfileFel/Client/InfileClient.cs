using AldeloInfileFel.Domain;
using AldeloInfileFel.Services;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace AldeloInfileFel.Client
{
    public class InfileClient
    {
        private static readonly HttpClient _client = new HttpClient();
        private static readonly Configuration _configuration = ConfigurationService.LoadConfiguration();

        public static string QueryTaxId(string taxId)
        {
            var request = new QueryTaxIdRequest
            {
                TaxId = taxId,
                TenantCode = _configuration.InfileTenantCode,
                TenantKey = _configuration.InfileTenantKey
            };

            var apiUrl = _configuration.InfileTaxIdQueryUrl;
            var payload = JsonConvert.SerializeObject(request);
            var content = new StringContent(payload, Encoding.UTF8);
            content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

            var response = _client.PostAsync(apiUrl, content)
                .Result;

            if (response.IsSuccessStatusCode)
            {
                var responsePayload = response.Content
                    .ReadAsStringAsync()
                    .Result;

                var responseObject = JsonConvert.DeserializeObject<QueryTaxIdResponse>(responsePayload);

                return responseObject.Name;
            }

            return "";
        }
    }
}
