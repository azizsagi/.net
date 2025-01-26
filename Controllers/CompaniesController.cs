using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CompaniesHouseApi.Controllers
{
    [ApiController]
    [Route("api/companies")]
    public class CompaniesController : ControllerBase
    {
        private static readonly string ApiKey = "YOUR_API_KEY";
        private static readonly string BaseUrl = "https://api.company-information.service.gov.uk/";

        private HttpClient CreateHttpClient()
        {
            var client = new HttpClient { BaseAddress = new System.Uri(BaseUrl) };
            var authHeader = System.Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{ApiKey}:"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeader);
            return client;
        }

        [HttpGet("search/{query}")]
        public async Task<IActionResult> SearchCompanies(string query)
        {
            using var client = CreateHttpClient();
            var response = await client.GetAsync($"search/companies?q={query}");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return Ok(data);
            }

            return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
        }

        [HttpGet("{companyNumber}")]
        public async Task<IActionResult> GetCompanyDetails(string companyNumber)
        {
            using var client = CreateHttpClient();
            var response = await client.GetAsync($"company/{companyNumber}");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return Ok(data);
            }

            return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
        }

        [HttpGet("{companyNumber}/filing-history")]
        public async Task<IActionResult> GetFilingHistory(string companyNumber)
        {
            using var client = CreateHttpClient();
            var response = await client.GetAsync($"company/{companyNumber}/filing-history");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return Ok(data);
            }

            return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
        }

        [HttpGet("{companyNumber}/officers")]
        public async Task<IActionResult> GetOfficers(string companyNumber)
        {
            using var client = CreateHttpClient();
            var response = await client.GetAsync($"company/{companyNumber}/officers");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return Ok(data);
            }

            return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
        }
    }
}