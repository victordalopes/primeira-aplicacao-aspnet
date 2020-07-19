using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int id { get; set; }
        [Display(Name = "Descrição")] // Para que apareça 'Descrição", com cedilha e acentos
        [Required(ErrorMessage = "O campo decrição é obrigatório!")]
        public string Descricao { get; set; }
    }
}
