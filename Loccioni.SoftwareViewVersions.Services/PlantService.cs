using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loccioni.SoftwareViewVersions.DataModels;
using Loccioni.SoftwareViewVersions.Db;

namespace Loccioni.SoftwareViewVersions.Services
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
		public void AddPlant(int plantIdClient, string plantName, string plantState, string plantCity, string plantAddress, string[] plantTag)
		{
			Add(plantName);
			plantId++;
			foreach (Plant plant in ldb.plants)
			{
				if (plantId == plant.Id)
				{
					plantId++;
				}
			}
			ldb.Add(new Plant(plantId, plantIdClient, plantName, plantState, plantCity, plantAddress, plantTag));
			ldb.SaveChanges();
		}
		public void Add(string name)
		{
			foreach (Client client in ldb.clients)
			{
				foreach (Plant plant in ldb.plants)
				{
					if (plant.Name == name)
						throw new Exception("Errore, Plant già esistente in questo cliente");
				}
			}
		}
		public void AggiornaPlant(int IdPlantModificato, string NomePlantModificato, string NazionePlantModificato, string CittaPlantModificato, string IndirizzoPlantModificato, string[] TagPlantModificato)
		{
			Plant plantDaModificare = ldb.plants.FirstOrDefault(p => p.Id == IdPlantModificato);
			if (plantDaModificare != null)
			{
				plantDaModificare.Name = NomePlantModificato;
				plantDaModificare.State = NazionePlantModificato;
				plantDaModificare.City = CittaPlantModificato;
				plantDaModificare.Address = IndirizzoPlantModificato;
				plantDaModificare.Tags = TagPlantModificato;
			}
			ldb.SaveChanges();
		}
		public void DeletePlant(int idPlantDeleted)
		{
			Plant plant = ldb.plants.FirstOrDefault(p => p.Id == idPlantDeleted);
			if (plant != null)
			{
				benchService.Delete(plant.Id);
				ldb.Remove(plant);
				ldb.SaveChanges();
			}
		}
		public void Delete(int idClientDeleted)
		{
			List<int> plantId = new List<int>();
			foreach (Plant plant in ldb.plants)
			{
				if (plant.IdClient == idClientDeleted)
					//Popolo la lista con gli ID  del plant, non con gli IDCLIENTE
					plantId.Add(plant.Id);
			}

			for (int i = 0; i < plantId.Count; i++)
				DeletePlant(plantId[i]);
		}
		public List<Plant> GetPlants()
		{
			return ldb.plants.ToList();
		}
	}
}
