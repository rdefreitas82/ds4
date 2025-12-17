namespace PlanillaWeb.Models
{
    public class EmpleadoDto
    {
        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public decimal SalarioMensual { get; set; }
        public string IdPuesto { get; set; }
    }
}
