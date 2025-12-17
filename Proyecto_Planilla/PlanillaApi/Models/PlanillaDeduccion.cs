using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaApi.Models
{
    public class PlanillaDeduccion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool EsFijo { get; set; }
        public bool AplicaAXIII { get; set; }
        public int IdEmpresa { get; set; }
    }
}
