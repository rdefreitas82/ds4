using PlanillaWeb.Services.Interfaces;
using PlanillaWeb.Models;
using System.Text.Json;

namespace PlanillaWeb.Services.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly HttpClient _httpClient;
        private JsonSerializerOptions opciones = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public  EmpleadoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<EmpleadoDto>> GetEmpleadosPorEmpresaAsync(int idEmpresa)
        {
            var response = await _httpClient.GetAsync($"empresa/{idEmpresa}/empleado");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<EmpleadoDto>>(json, opciones);
        }

        public async Task<List<EmpleadoDto>> GetAllEmpleadosAsync()
        {
            var response = await _httpClient.GetAsync("empleado");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<EmpleadoDto>>(json, opciones);
        }

        public async Task<EmpleadoDto?> GetEmpleadoByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"empleado/{id}");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<EmpleadoDto>(json, opciones);
        }

        public async Task<bool> UpdateEmpleadoAsync(EmpleadoDto empleado)
        {
            var json = JsonSerializer.Serialize(empleado);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"empleado/{empleado.Id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<int> CreateEmpleadoAsync(EmpleadoDto empleado)
        {
            var json = JsonSerializer.Serialize(empleado);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"empresa/{empleado.IdEmpresa}/empleado", content);
            response.EnsureSuccessStatusCode();
            var responseJson = await response.Content.ReadAsStringAsync();
            var nuevoEmpleado = JsonSerializer.Deserialize<EmpleadoDto>(responseJson, opciones);
            return nuevoEmpleado != null ? nuevoEmpleado.Id : 0;
        }

        public async Task<bool> BorrarEmpleadoAsync(int idEmpleado)
        {
            var response = await _httpClient.DeleteAsync($"empleado/{idEmpleado}");
            return response.IsSuccessStatusCode;
        }
    }
}
