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
    public class ContribuyentesControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public ContribuyentesControllerTests(WebApplicationFactory<Startup> factory) 
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetAllContribuyentes_ReturSuccessStatusCode()
        {
            var response = await _client.GetAsync("/api/Contribuyentes/Listar");

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetContribuyenteByRncCedula_With_ValidId_ReturnsSuccessStatusCode()
        {
            var validId = "98754321012";

            var response = await _client.GetAsync($"/api/Contribuyentes/Obtener/{validId}");

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }


        [Fact]
        public async Task GetContribuyenteByRncCedula_WithInvalidId_ReturnsNotFoundStatusCode()
        {
           
            var invalidId = "123";

            var response = await _client.GetAsync($"/api/Contribuyentes/Obtener/{invalidId}");

 
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

    }

  
}
