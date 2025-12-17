using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaApi.Models
{
    public class Empleado
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public virtual Empresa Empresa { get; set; }
        [MaxLength(25)]
        public string Cedula { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public DateTime FechaContratacion {  get; set; }
        [Required]
        [Column(TypeName = "decimal(14,4)")]
        public decimal SalarioMensual { get; set; }
        //public int IdDepartamento { get; set; }
        [MaxLength(50)]
        public string IdPuesto { get; set; }
        //[MaxLength(15)]
        //public string Estado { get; set; }
    }
}
