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

		public void AddBench(int idPlant, string name, string urlGit, string[] tags, byte[] logo)
		{
			Add(name);
			benchId++;
			foreach (Bench bench in ldb.benches)
			{
				if (benchId == bench.Id)
				{
					benchId++;
				}
			}
			ldb.Add(new Bench(benchId, idPlant, name, urlGit, tags.Where(t=>!string.IsNullOrEmpty(t)).ToArray(), logo));
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
		public void UploadBench(int id, string name, string urlGit, string[] tag)
		{
			Bench bancoDaModificare = ldb.benches.FirstOrDefault(b => b.Id == id);
			if (bancoDaModificare != null)
			{
				bancoDaModificare.Name = name;
				bancoDaModificare.UrlGit = urlGit;
				bancoDaModificare.Tags = tag;
			}
			ldb.SaveChanges();
		}
		public void DeleteBench(int id)
		{
			Bench bench = ldb.benches.FirstOrDefault(b => b.Id == id);
			if (bench != null)
			{
				ldb.Remove(bench);
				ldb.SaveChanges();
			}
		}
		public void Delete(int idPlant)
		{
			List<int> benchId = new List<int>();
			foreach (Bench bench in ldb.benches)
			{
				if (bench.IdPlant == idPlant)
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
		public Bench GetBenchByName(string name)
		{
			foreach (Bench bench in GetBenches())
			{
				if (bench.Name == name)
					return bench;
			}
			return null;
		}
	}
}