using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Required (ErrorMessage = "O campo Título é obrigatório!")]
        public string Titulo { get; set; }
        [Required (ErrorMessage = "O campo Diretor é obrigatório!")]
        public string Diretor { get; set; }
        [StringLength(10, ErrorMessage = "O campo gênero não pode ter mais de 10 caracteres!")]
        public string Genero { get; set; }
        [Required, Range(1, 600, ErrorMessage = "A duração só pode estar entre 1 e 600 minutos!")]
        public int Duracao { get; set; }
    }
}
