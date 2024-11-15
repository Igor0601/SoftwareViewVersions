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
		public List<Plant> plants;
		public int plantId;
		BenchService benchService;
		ClientService clientService;
		public PlantService(BenchService benchService, ClientService clientService)
		{
			plants = new List<Plant>();
			this.benchService = benchService;
			this.clientService = clientService;
		}
		public void AggiungiPlant(int plantIdClient, string plantName, string plantState, string plantCity, string plantAddress, string[] plantTag) 
		{
			Add(plantName);
			plantId++;
			Plant newPlant = new Plant(plantId, plantIdClient, plantName, plantState, plantCity, plantAddress, plantTag);
			plants.Add(newPlant);
		}
		public void Add(string name) 
		{
			foreach(Client client in clientService.GetClientes())
			{
				foreach (Plant plant in plants)
				{
					if (plant.name == name)
						MessageBox.Show("Errore, Plant già esistente in questo cliente");
				}
			}
			
		}
		public void AggiornaPlant(int IdPlantModificato, string NomePlantModificato, string NazionePlantModificato, string CittaPlantModificato, string IndirizzoPlantModificato, string[] TagPlantModificato) 
		{
			Plant plantDaModificare = plants.FirstOrDefault(p => p.id == IdPlantModificato);
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
			Plant plantDaEliminare = plants.FirstOrDefault(p => p.id == idPlantDeleted);
			if (plantDaEliminare != null)
			{
				benchService.Delete(idPlantDeleted);
				plants.Remove(plantDaEliminare);
			}
		}
		public void Delete(int idClientDeleted) 
		{
			List<int> plantId = new List<int>();
			foreach(Plant plant in plants) 
			{
				if(plant.idClient == idClientDeleted)
					plantId.Add(plant.idClient);
			}
			for(int i = 0; i < plantId.Count; i++)
				DeletePlant(plantId[i]);
		}
		public List<Plant> GetPlants()
		{
			return plants;
		}
	}
}
