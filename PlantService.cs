using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
	public class PlantService
	{
		public int plantId;
		LoccioniDbContext ldb;
		BenchService benchService;
		public PlantService(BenchService benchService)
		{
			ldb = new LoccioniDbContext();
			this.benchService = benchService;
		}
		public void AggiungiPlant(int plantIdClient, string plantName, string plantState, string plantCity, string plantAddress, string[] plantTag) 
		{
			Add(plantName);
			plantId++;
			foreach (Plant plant in ldb.plants)
			{
				if (plantId == plant.id)
				{
					plantId++;
				}
			}
			ldb.Add(new Plant(plantId, plantIdClient, plantName, plantState, plantCity, plantAddress, plantTag));
		}
		public void Add(string name) 
		{
			foreach(Client client in ldb.clients)
			{
				foreach (Plant plant in ldb.plants)
				{
					if (plant.name == name)
						MessageBox.Show("Errore, Plant già esistente in questo cliente");
				}
			}
		}
		public void AggiornaPlant(int IdPlantModificato, string NomePlantModificato, string NazionePlantModificato, string CittaPlantModificato, string IndirizzoPlantModificato, string[] TagPlantModificato) 
		{
			Plant plantDaModificare = ldb.plants.FirstOrDefault(p => p.id == IdPlantModificato);
			if(plantDaModificare != null)
			{
				plantDaModificare.name = NomePlantModificato;
				plantDaModificare.state = NazionePlantModificato;
				plantDaModificare.city = CittaPlantModificato;
				plantDaModificare.address = IndirizzoPlantModificato;
				plantDaModificare.tags = TagPlantModificato;
			}
		}
		public void DeletePlant(int idPlantDeleted) 
		{
			Plant plantDaEliminare = ldb.plants.FirstOrDefault(p => p.id == idPlantDeleted);
			if (plantDaEliminare != null)
			{
				benchService.Delete(idPlantDeleted);
				ldb.plants.Remove(plantDaEliminare);
			}
		}
		public void Delete(int idClientDeleted) 
		{
			List<int> plantId = new List<int>();
			foreach(Plant plant in ldb.plants) 
			{
				if(plant.idClient == idClientDeleted)
					plantId.Add(plant.idClient);
			}
			for(int i = 0; i < plantId.Count; i++)
				DeletePlant(plantId[i]);
		}
		public LoccioniDbContext GetPlants()
		{ 
			return ldb;
		}
		
	}
}
