using PlanillaWeb.Models;
namespace PlanillaWeb.Services.Interfaces
{
    public interface IEmpresaService
    {
        Task<List<EmpresaSelectDto>> GetEmpresaSelectAsync();
        Task<List<EmpresaDto>> GetAllEmpresasAsync();
        Task<EmpresaDto?> GetEmpresaByIdAsync(int id);
        Task<bool> UpdateEmpresaAsync(EmpresaDto empresa);
        Task<int> CreateEmpresaAsync(EmpresaDto empresa);
    }
}
