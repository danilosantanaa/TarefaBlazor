using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Features;

namespace TarefaBlazor.Helpers {
	public class CustomAction : ActionResult{
		private readonly Exception _e;

		public CustomAction(Exception exception) => _e = exception;

		public override void ExecuteResult(ActionContext context)
		{
			var httpResponse = context.HttpContext.Response;

			httpResponse.StatusCode = 400;
			context.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = _e.InnerException is null ? _e.Message : _e.InnerException.Message;
		}
	}
}
