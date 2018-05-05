using System.Net.Http;
using System.Threading.Tasks;
using CS.CoffeePoint;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;

namespace IntegrationTests
{
    public class PlaceController
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public PlaceController()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Test]
        public async Task ShouldCallPost()
        {
            var response = await _client.GetAsync("/");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            responseString.Should().NotBeEmpty();
        }
    }
}
