using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TarefaBlazor.Models {
    public class Etapa {
        public int ID { get; set; }

        [MaxLength(200)]
        [Required(ErrorMessage = "Informe o nome da etapa")]
        [MinLength(6, ErrorMessage = "Informe pelo menos {0} caracteres!")]

        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }

        public List<Tarefa> Tarefas { get; set; }   
    }
}
