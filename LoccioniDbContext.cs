using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prova
{
	internal class LoccioniDbContext : DbContext
	{
		public DbSet<Client> clients { get; set; }
		public DbSet<Plant> plants { get; set; }
		public DbSet<Bench> benches { get; set; }
		public string DbPath { get; }
		public LoccioniDbContext()
		{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath = System.IO.Path.Join(path, "LoccioniDb.db");
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite($"Data Source = {DbPath}");
		}
	}
}
