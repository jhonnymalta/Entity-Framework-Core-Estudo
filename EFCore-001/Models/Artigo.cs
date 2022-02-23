using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_001.Models
{
    public class Artigo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Titulo { get; set; }
        [MaxLength(500)]
        public string texto { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DataCriacao { get; set; }

        [ForeignKey("Categoria")]
        public int Categoria_ID { get; set; }
       
    }
}
