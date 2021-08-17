using InvoiceNinjaSDK.Model;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvoiceNinjaSDK
{
    public class TestClient
    {
        string token = "lE5Q8BwFG326MxeemI0Ll6P1xfWKwqk9PoeiZJnCmd8Gpy5l04hGurvvSHSicqVA";
        string apiSecret = "password"; // used on public hosted invoice ninja
        string baseUrl = "https://invoice.sufficit.com.br";
        string endpoint = "/api/v1/clients";

        private readonly ILogger _logger;
        private readonly HttpClient _http;

        public TestClient(ILogger logger)
        {
            _logger = logger;
            _http = new HttpClient();
            // _http.DefaultRequestHeaders.Add("X-Api-Secret", apiSecret);
            _http.DefaultRequestHeaders.Add("X-Api-Token", token);
        }

        /// <summary>
        /// Filter by name, multiple results and sliceds results
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Model.ModelClient>> GetByNameAsync(string filter, CancellationToken cancellationToken = default)
        {
            string parameters = $"?name={ filter }";

            var response = await _http.GetAsync($"{ baseUrl }{ endpoint }{ parameters }", cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<Model.ModelClient>>>(data);
                return apiResponse.Data;
            }

            throw new HttpRequestException(response.StatusCode.ToString());
        }

        /// <summary>
        /// Filter by CPF/CNPJ Unique Governement key (Exactly Match)
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Model.ModelClient> GetByIDNumberAsync(string filter, CancellationToken cancellationToken = default)
        {
            string parameters = $"?id_number={ filter }";
            
            var response = await _http.GetAsync($"{ baseUrl }{ endpoint }{ parameters }", cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<Model.ModelClient>>>(data);
                return apiResponse.Data.FirstOrDefault();
            }

            throw new HttpRequestException(response.StatusCode.ToString());
        }

        /// <summary>
        /// Generic Method, try by your own
        /// </summary>
        /// <param name="atribute"></param>
        /// <param name="value"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Model.ModelClient>> GetClientAsync(string atribute = default, string value = default, CancellationToken cancellationToken = default)
        {            
            string parameters = string.Empty;

            if (!string.IsNullOrWhiteSpace(atribute))
                parameters = $"?{ atribute }={ value }";

            var response = await _http.GetAsync($"{ baseUrl }{ endpoint }{ parameters }", cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<Model.ModelClient>>>(data);
                return apiResponse.Data;
            }

            throw new HttpRequestException(response.StatusCode.ToString());
        }

        /// <summary>
        /// Gets a default object (hash and settings) to update 
        /// </summary>
        /// <returns></returns>
        public async Task<Model.ModelClient> GenerateClientAsync(CancellationToken cancellationToken = default)
        {
            string parameters = "/create";

            var response = await _http.GetAsync($"{ baseUrl }{ endpoint }{ parameters }", cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Model.ModelClient>>(data);
                return apiResponse.Data;
            }

            throw new HttpRequestException(response.StatusCode.ToString());
        }

        /// <summary>
        /// Gets a default object (hash and settings) to update 
        /// </summary>
        /// <returns></returns>
        public async Task<Model.ModelClient> EditClientAsync(string id, CancellationToken cancellationToken = default)
        {
            string parameters = "/:id/edit";
            parameters = parameters.Replace(":id", id);

            var response = await _http.GetAsync($"{ baseUrl }{ endpoint }{ parameters }", cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Model.ModelClient>>(data);
                return apiResponse.Data;
            }

            throw new HttpRequestException(response.StatusCode.ToString());
        }

        public async System.Threading.Tasks.Task AddClientAsync(ModelClient client, CancellationToken cancellationToken = default)
        {
            string parameters = string.Empty;

            var json = JsonConvert.SerializeObject(client);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _http.PostAsync($"{ baseUrl }{ endpoint }{ parameters }", content, cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException(response.StatusCode.ToString());
            }
        }

        public async System.Threading.Tasks.Task UpdateClientAsync(ModelClient client, CancellationToken cancellationToken = default)
        {
            string parameters = "/:id";
            parameters = parameters.Replace(":id", client.Id);

            var json = JsonConvert.SerializeObject(client);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _http.PutAsync($"{ baseUrl }{ endpoint }{ parameters }", content, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"{ ((int)response.StatusCode) } :: { response.ReasonPhrase }", new Exception(json));
            }
        }
    }
}
