using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaApi.Models
{
    [Table("Empresa")]
    public class Empresa
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string RazonSocial { get; set; }
        [Required]
        [MaxLength(200)]
        public string NombreComercial { get; set; }
        [Required]
        [MaxLength(20)]
        public string Ruc {  get; set; }
        [Required]
        [MaxLength(2)]
        public string Dv { get; set; }
        [MaxLength(15)]
        public string NumeroPatronal { get; set; }
        [MaxLength(255)]
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
