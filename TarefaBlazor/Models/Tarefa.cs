namespace TarefaBlazor.Models {
    public class Tarefa {
        public int ID { get; set; } 
        public string Descricao { get; set; }
        public DateTime Tempo_Inicial { get; set; }
        public DateTime Tempo_Final { get; set; }
        public string UsuarioTarefaID { get; set; }
    }
}
