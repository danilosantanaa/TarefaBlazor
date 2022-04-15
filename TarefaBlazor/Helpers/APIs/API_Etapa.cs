namespace TarefaBlazor.Helpers.APIs {
	public class API_Etapa {
		protected HttpClient httpClient;
		public const string API_URL = "api/etapas";
		public API_Etapa(HttpClient httpClient) { 
			this.httpClient = httpClient;
		}
	}
}
