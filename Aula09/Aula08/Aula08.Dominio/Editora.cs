using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08.Dominio
{
    public class Editora
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha o nome da editora")]
        public string Nome { get; set; }
    }
}
