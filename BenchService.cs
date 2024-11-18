using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Prova
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
				if (benchId == bench.id)
				{
					benchId++;
				}
			}
			ldb.Add(new Bench(benchId, benchIdPlant, benchName, benchurlGit, benchTag));	
		}
		public void Add(string name) 
		{
			foreach(Plant plant in ldb.plants)
			{
				foreach (Bench bench in ldb.benches)
				{
					if (bench.name == name)
						MessageBox.Show("Errore, banco già esiste in questo plant");
				}
			}
		}
		public void AggiornaBanco(int IdBancoModificato, string NomeBancoModificato, string UrlGitBancoModificato, string[] TagBancoModificato) 
		{
			Bench bancoDaModificare = ldb.benches.FirstOrDefault(b => b.id == IdBancoModificato);
			if(bancoDaModificare != null)
			{
				bancoDaModificare.name = NomeBancoModificato;
				bancoDaModificare.urlGit = UrlGitBancoModificato;
				bancoDaModificare.tags = TagBancoModificato;
			}
		}
		public void DeleteBanco(int idBancDeleted) 
		{
			Bench bancoDaEliminare = ldb.benches.FirstOrDefault(b => b.id == idBancDeleted);
			if (bancoDaEliminare != null) 
				ldb.benches.Remove(bancoDaEliminare);
		}
		public void Delete(int idPlantDeleted) 
		{
			List<int> benchId = new List<int>();
			foreach (Bench bench in ldb.benches) 
			{
				if(bench.idPlant ==  idPlantDeleted)
					benchId.Add(bench.idPlant);
			}
			for (int i = 0; i < benchId.Count; i++)
				DeleteBanco(benchId[i]);
		}
		public LoccioniDbContext GetBenches()
		{
			return ldb;
		}
	}
}
