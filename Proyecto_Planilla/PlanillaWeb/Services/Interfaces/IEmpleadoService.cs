using PlanillaWeb.Models;

namespace PlanillaWeb.Services.Interfaces
{
    public interface IEmpleadoService
    {
        Task<List<EmpleadoDto>> GetEmpleadosPorEmpresaAsync(int idEmpresa);
        Task<List<EmpleadoDto>> GetAllEmpleadosAsync();
        Task<EmpleadoDto?> GetEmpleadoByIdAsync(int id);
        Task<bool> UpdateEmpleadoAsync(EmpleadoDto empleado);
        Task<int> CreateEmpleadoAsync(EmpleadoDto empleado);
        Task<bool> BorrarEmpleadoAsync(int idEmpleado);
    }
}
