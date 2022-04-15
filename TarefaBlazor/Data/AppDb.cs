using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TarefaBlazor.Models;

namespace TarefaBlazor.Data {
	public class AppDb : DbContext {
		public AppDb(DbContextOptions<AppDb> options) : base(options) {}

		protected override void OnModelCreating(ModelBuilder modelBuilder) { }

		public DbSet<Usuario> Usuario { get; set; }

		public DbSet<Tarefa> Tarefa { get; set; }

		public DbSet<Etapa> Etapas { get; set; }
	}
}
