using System.ComponentModel.DataAnnotations;

namespace Eleitores.Models
{
    public class Ausencia
    {
        private const int V = 11;
        [Required]
        [StringLength(V)]
        public string CPF { get; set; }
    }

}
