using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loccioni.SoftwareViewVersions.Db;
using Loccioni.SoftwareViewVersions.DataModels;

namespace Loccioni.SoftwareViewVersions.Services
{
	public class BenchService
	{
		public int benchId;
		LoccioniDbContext ldb;
		public BenchService()
		{
			ldb = new LoccioniDbContext();
		}
		public void AddBench(int benchIdPlant, string benchName, string benchurlGit, string[] benchTag)
		{
			Add(benchName);
			benchId++;
			foreach (Bench bench in ldb.benches)
			{
				if (benchId == bench.Id)
				{
					benchId++;
				}
			}
			ldb.Add(new Bench(benchId, benchIdPlant, benchName, benchurlGit, benchTag));
			ldb.SaveChanges();
		}
		public void Add(string name)
		{
			foreach (Plant plant in ldb.plants)
			{
				foreach (Bench bench in ldb.benches)
				{
					if (bench.Name == name)
						throw new Exception("Errore, banco già esiste in questo plant");
				}
			}
		}
		public void AggiornaBanco(int IdBancoModificato, string NomeBancoModificato, string UrlGitBancoModificato, string[] TagBancoModificato)
		{
			Bench bancoDaModificare = ldb.benches.FirstOrDefault(b => b.Id == IdBancoModificato);
			if (bancoDaModificare != null)
			{
				bancoDaModificare.Name = NomeBancoModificato;
				bancoDaModificare.UrlGit = UrlGitBancoModificato;
				bancoDaModificare.Tags = TagBancoModificato;
			}
			ldb.SaveChanges();
		}
		public void DeleteBench(int idBenchDeleted)
		{
			Bench bench = ldb.benches.FirstOrDefault(b => b.Id == idBenchDeleted);
			if (bench != null)
			{
				ldb.Remove(bench);
				ldb.SaveChanges();
			}
		}
		public void Delete(int idPlantDeleted)
		{
			List<int> benchId = new List<int>();
			foreach (Bench bench in ldb.benches)
			{
				if (bench.IdPlant == idPlantDeleted)
					//Popolo la lista con gli ID del benh, non con gli IDPLANT
					benchId.Add(bench.Id);
			}
			for (int i = 0; i < benchId.Count; i++)
			{
				DeleteBench(benchId[i]);
			}
		}
		public List<Bench> GetBenches()
		{
			return ldb.benches.ToList();
		}
	}
}
