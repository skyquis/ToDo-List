using Microsoft.EntityFrameworkCore;
using ToDo_List.Models;

namespace ToDo_List.Data
{
	public class ToDoContext : DbContext
	{
		public ToDoContext(DbContextOptions<ToDoContext> options)
			: base(options) { }

		public DbSet<ToDo> ToDos { get; set; } = null!;
		public DbSet<Category> Categories { get; set; } = null!;
		public DbSet<Status> Statuses { get; set; } = null!;

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category { CategoryId = "work", Name = "Work" },
				new Category { CategoryId = "home", Name = "Home" },
				new Category { CategoryId = "ex", Name = "Exercise" },
				new Category { CategoryId = "shop", Name = "Shopping" },
				new Category { CategoryId = "call", Name = "Contact" },
				new Category { CategoryId = "adulting", Name = "Adulting"}
				);
			modelBuilder.Entity<Status>().HasData(
				new Status { StatusId = "open", Name = "Open" },
				new Status { StatusId = "closed", Name = "Completed" },
				new Status { StatusId = "in progress", Name = "In Progress" }
				);

		}
	}
}
