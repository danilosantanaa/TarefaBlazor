using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TarefaBlazor.Models;

namespace TarefaBlazor.Data {
	public class AppDb : IdentityDbContext<Usuario> {

	}
}
