
using IdentityModel.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Test.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class testIdentityServerController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var client = new HttpClient();
            var disco = await client.GetDiscoveryDocumentAsync("https://localhost:7029");
            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.TokenEndpoint,

                ClientId = "clinet_mobile",
                ClientSecret = "secret",
                Scope = "myApi.read"
            });





            var apiClient = new HttpClient();
            apiClient.SetBearerToken(tokenResponse.AccessToken);

            var response = await apiClient.GetAsync("https://localhost:7029/api/Product/getProducts");
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                return Ok(content);
            }
            return NotFound("Not Found Products");
        }
    }
}
