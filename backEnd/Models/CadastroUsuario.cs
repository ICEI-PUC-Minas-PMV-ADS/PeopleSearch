using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Back_ps.Models
{
    [Table("Usuarios")]
    public class CadastroUsuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar o Nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar o Email!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar a Senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar o Genero!")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar a idade!")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o telefone!")]

        public string Telefone { get; set; }
    }
}
