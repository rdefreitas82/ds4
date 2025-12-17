using PlanillaWeb.Services.Interfaces;
using PlanillaWeb.Models;
using System.Text.Json;

namespace PlanillaWeb.Services.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly HttpClient _httpClient;
        private JsonSerializerOptions opciones = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public EmpresaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<EmpresaSelectDto>> GetEmpresaSelectAsync()
        {
            var response = await _httpClient.GetAsync("empresa");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<EmpresaSelectDto>>(json, opciones);
        }


        public async Task<List<EmpresaDto>> GetAllEmpresasAsync()
        {
            var response = await _httpClient.GetAsync("empresa");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<EmpresaDto>>(json, opciones);
        }

        public async Task<EmpresaDto?> GetEmpresaByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"empresa/{id}");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<EmpresaDto>(json, opciones);

        }

        public async Task<bool> UpdateEmpresaAsync(EmpresaDto empresa)
        {
            var json = JsonSerializer.Serialize(empresa);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"empresa/{empresa.Id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<int> CreateEmpresaAsync(EmpresaDto empresa)
        {
            var json = JsonSerializer.Serialize(empresa);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("empresa", content);
            response.EnsureSuccessStatusCode();
            var responseJson = await response.Content.ReadAsStringAsync();
            var createdEmpresa = JsonSerializer.Deserialize<EmpresaDto>(responseJson, opciones);
            return createdEmpresa != null ? createdEmpresa.Id : 0;
        }
    }
}