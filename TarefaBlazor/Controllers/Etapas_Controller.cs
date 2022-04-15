using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TarefaBlazor.Data;
using TarefaBlazor.Helpers;
using TarefaBlazor.Helpers.APIs;
using TarefaBlazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace TarefaBlazor.Controllers {
	[Route(API_Etapa.API_URL)]
	[ApiController]
	public class Etapas_Controller : ControllerBase {
		readonly AppDb _context;

		public Etapas_Controller(AppDb context) => _context = context;

		#region GET
		[HttpGet("{id}")]
		public async Task<ActionResult<Etapa?>> Get(int id)
		{

			if(await EtapasExistes(id)) return await Task.Run(() => _context.Etapas.AsNoTracking().Where(x => x.ID == id).FirstOrDefaultAsync());

			return NotFound();
		}

		[Route("{action}")]
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Etapa>>> Get(int id, string descricao)
		{
			return await _context.Etapas.Include(x => x.Tarefas)
										.AsNoTracking()
										.Where(x => id > 0 ? x.ID == id : x.ID > 0)
										.Where(x => descricao == string.Empty ? x.Descricao.ToLower().Contains(descricao.ToLower()) : x.ID > 0)
										.ToListAsync();
		}
		#endregion

		#region PUT 
		[HttpPut("id")]
		public async Task<IActionResult> Put(int id, Etapa etapa)
		{
			try {
				if(id != etapa.ID) return BadRequest();

				await Task.Run(() => _context.Entry(etapa).State = EntityState.Modified);
				await _context.SaveChangesAsync();
			}
			catch (Exception e) {
				return new CustomAction(e);
			}

			return NoContent();
		}
		#endregion

		#region POST
		[Route("{action}")]
		[HttpPost]
		public async Task<ActionResult<Etapa>> Post(Etapa etapa)
		{
			try {
				await _context.Etapas.AddAsync(etapa);
				await _context.SaveChangesAsync();

				return CreatedAtRoute("Get", new { id = etapa.ID }, etapa);
			} catch (Exception e) {
				return new CustomAction(e);
			}
		}
		#endregion

		#region OUTROS
		async Task<bool> EtapasExistes(int id) => await _context.Etapas.AsNoTracking().AnyAsync(x => x.ID == id);
		#endregion
	}
}
