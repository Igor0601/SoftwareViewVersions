using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
	public class BenchService
	{
		List<Bench> benches;
		public int benchId;
		PlantService plantService;
		public BenchService(PlantService plantService)
		{
			this.benches = new List<Bench>();
			this.plantService = plantService;
		}
		public void AggiungiBanco(int bancoIdPlant, string bancoNome, string bancoUrlgit, string[] bancoTag) 
		{
			Add(bancoNome);
			benchId++;
			Bench newBench = new Bench(benchId, bancoIdPlant, bancoNome, bancoUrlgit, bancoTag);
			benches.Add(newBench);	
		}
		public void Add(string name) 
		{
			foreach(Plant plant in plantService.GetPlants())
			{
				foreach (Bench bench in benches)
				{
					if (bench.name == name)
						MessageBox.Show("Errore, banco già esiste in questo plant");
				}
			}
			
		}
		public void AggiornaBanco(int IdBancoModificato, string NomeBancoModificato, string UrlGitBancoModificato, string[] TagBancoModificato) 
		{
			Bench bancoDaModificare = benches.FirstOrDefault(b => b.id == IdBancoModificato);
			if(bancoDaModificare != null)
			{
				bancoDaModificare.name = NomeBancoModificato;
				bancoDaModificare.urlGit = UrlGitBancoModificato;
				bancoDaModificare.tags = TagBancoModificato;
			}
		}
		public void DeleteBanco(int idBancDeleted) 
		{
			Bench bancoDaEliminare = benches.FirstOrDefault(b => b.id == idBancDeleted);
			if (bancoDaEliminare != null) 
				benches.Remove(bancoDaEliminare);
		}
		public void Delete(int idPlantDeleted) 
		{
			List<int> benchId = new List<int>();
			foreach (Bench bench in benches) 
			{
				if(bench.idPlant ==  idPlantDeleted)
					benchId.Add(bench.idPlant);
			}
			for (int i = 0; i < benchId.Count; i++)
				DeleteBanco(benchId[i]);
		}
		public List<Bench> GetBanchi()
		{
			return benches;
		}
	}
}
