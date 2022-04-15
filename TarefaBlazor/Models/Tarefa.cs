using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TarefaBlazor.Models {
    public class Tarefa {
  
        public int ID { get; set; } 

        [MaxLength(500)]
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="Por favor informe uma {0}")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe uma data inicial")]
        public DateTime Tempo_Inicial { get; set; }

        [Required(ErrorMessage = "Informe uma data final")]
        public DateTime Tempo_Final { get; set; }

        public string UsuarioTarefaID { get; set; }

        [ForeignKey("EtapaID")]
        public int EtapaID { get; set; }
        public Etapa Etapa { get; set; }    
    }
}
