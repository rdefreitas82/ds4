using System.ComponentModel.DataAnnotations;

namespace PlanillaWeb.Models
{
    public class EmpresaDto
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string Ruc { get; set; }
        public string Dv { get; set; }
        public string NumeroPatronal { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
    }

    public class EmpresaSelectDto
    {
        public int Id { get; set; }
        public string NombreComercial { get; set; }
    }
}
