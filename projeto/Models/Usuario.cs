using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        [StringLength(25)]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Obrigatório")]
        [StringLength(600)]
        public string sobre { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        [StringLength(600)]
        public string search { get; set; }
    }
}
