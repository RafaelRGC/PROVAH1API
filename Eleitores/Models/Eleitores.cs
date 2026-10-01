using System.ComponentModel.DataAnnotations;

namespace EleicaoApi.Models
{
    public class Eleitor
    {
        private const int V = 11;

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required]
        [StringLength(V)]
        public string CPF { get; set; }

        [Required]
        [StringLength(50)]
        public int TituloEleitor { get; set; }

        [Required]
        [StringLength(2)]
        public string UF { get; set; }

        [Required]
        [System.ComponentModel.DataAnnotations.Range(10, 99)]
        public int Numero { get; set; }
    }

}