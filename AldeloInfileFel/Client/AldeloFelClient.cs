using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using AldeloInfileFel.Domain;

namespace AldeloInfileFel.Client
{
    public class AldeloFelClient
    {
        private static HttpClient _client = new HttpClient();

        public static InvoiceGenerationResponse GenerateInvoiceRequest(InvoiceGenerationRequest request)
        {
            var apiUrl = Environment.GetEnvironmentVariable("ALDELO_FEL_API_URL");
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

        private static InvoiceGenerationResponse BuildSuccessResponse(string message)
        {
            return new InvoiceGenerationResponse()
            {
                Success = true,
                InvoiceInformation = JsonConvert.DeserializeObject<InvoiceInformation>(message),
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
