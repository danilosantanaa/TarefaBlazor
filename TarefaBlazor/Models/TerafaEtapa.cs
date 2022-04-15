using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TarefaBlazor.Models {
	public class TerafaEtapa {
		public int ID { get; set; }

		[ForeignKey("TarefaID")]
		public int TarefaID { get; set; }
		public Tarefa Tarefa { get; set; }

		[ForeignKey("EtapaID")]
		public int EtapaID { get; set; }
		public Etapa Etapa { get; set; }

	}
}
