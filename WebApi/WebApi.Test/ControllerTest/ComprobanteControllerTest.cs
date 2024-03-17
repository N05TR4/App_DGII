using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json;
using WebApi.Models;
using Xunit;

namespace WebApi.Test.ControllerTest
{
    public class ComprobanteControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public ComprobanteControllerTest(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }


        [Fact]
        public async Task GetAllComprobantes_ReturSuccessStatusCode()
        {
            var response = await _client.GetAsync("/api/Comprobantes/Listar");

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetComprobanteById_WithValidId_ReturnsSuccessStatusCode()
        {
            var validId = 1;

            var response = await _client.GetAsync($"/api/Comprobantes/Obtener/{validId}");

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetComprobanteById_WithInvalidId_ReturnsNotFoundStatusCode()
        {

            var invalidId = "123";

            var response = await _client.GetAsync($"/api/Comprobantes/Obtener/{invalidId}");


            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
