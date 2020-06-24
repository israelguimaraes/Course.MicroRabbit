using MicroRabbit.Presentation.Web.Models.DTO;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MicroRabbit.Presentation.Web.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;

        public TransferService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task Transfer(TransferDTO transferDTO)
        {
            var uri = "https://localhost:5001/api/banking";
            var json = JsonConvert.SerializeObject(transferDTO);
            var transferContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
