using AldeloInfileFel.Domain;
using AldeloInfileFel.Services;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace AldeloInfileFel.Client
{
    public class AldeloFelClient
    {
        private static readonly HttpClient _client = new HttpClient();
        private static readonly Configuration _configuration = ConfigurationService.LoadConfiguration();

        public static InvoiceGenerationResponse GenerateInvoiceRequest(GenerationRequest request)
        {            
            var apiUrl = _configuration.FelApiUrl;
            var payload = JsonConvert.SerializeObject(request);
            var content = new StringContent(payload, Encoding.UTF8);
            content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

            var response = _client.PostAsync(apiUrl, content).Result;

            var responsePayload = response.Content
                .ReadAsStringAsync()
                .Result;

            if (response.IsSuccessStatusCode)
            {
                return BuildSuccessResponse(responsePayload);
            }

            return BuildErrorResponse(responsePayload);
        }

        public static ApiStatus GetApiFelStatus()
        {
            var healthUrl = _configuration.FelApiHealth;

            var response = _client.GetAsync(healthUrl);

            var responsePayload = response.Result
                .EnsureSuccessStatusCode()
                .Content
                .ReadAsStringAsync()
                .Result;

            return JsonConvert.DeserializeObject<ApiStatus>(responsePayload);
        }

        // ------------------------------------------------------------------------------------------------

        private static InvoiceGenerationResponse BuildSuccessResponse(string message)
        {

            var response = JsonConvert.DeserializeObject<GenerationResponse>(message);

            return new InvoiceGenerationResponse()
            {
                Success = true,
                Invoices = response.Invoices,
            };
        }

        private static InvoiceGenerationResponse BuildErrorResponse(string message)
        {
            var errorResponse = JsonConvert.DeserializeObject<InvoiceGenerationErrorResponse>(message);
            return new InvoiceGenerationResponse()
            {
                Success = false,
                Errors = errorResponse.Errors
            };
        }
    }
}
