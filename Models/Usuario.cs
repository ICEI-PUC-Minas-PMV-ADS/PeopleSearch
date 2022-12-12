using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Back_ps.Models
{
    [Table("User")]
    public class Usuario
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email!")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Senha!")]
        public string Senha { get; set; }
    }
}
