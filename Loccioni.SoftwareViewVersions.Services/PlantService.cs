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

		public LoccioniDbContext LoccioniDbContext
		{
			get => default;
			set
			{
			}
		}

		public void AddPlant(int idClient, string name, string state, string city, string address, string[] tags, byte[] logo)
		{
			Add(name);
			plantId++;
			foreach (Plant plant in ldb.plants)
			{
				if (plantId == plant.Id)
				{
					plantId++;
				}
			}
			ldb.Add(new Plant(plantId, idClient, name, state, city, address, tags, logo));
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
		public void UploadPlant(int id, string name, string state, string city, string address, string[] tag)
		{
			Plant plantDaModificare = ldb.plants.FirstOrDefault(p => p.Id == id);
			if (plantDaModificare != null)
			{
				plantDaModificare.Name = name;
				plantDaModificare.State = state;
				plantDaModificare.City = city;
				plantDaModificare.Address = address;
				plantDaModificare.Tags = tag;
			}
			ldb.SaveChanges();
		}
		public void DeletePlant(int id)
		{
			Plant plant = ldb.plants.FirstOrDefault(p => p.Id == id);
			if (plant != null)
			{
				benchService.Delete(plant.Id);
				ldb.Remove(plant);
				ldb.SaveChanges();
			}
		}
		public void Delete(int idClient)
		{
			List<int> plantId = new List<int>();
			foreach (Plant plant in ldb.plants)
			{
				if (plant.IdClient == idClient)
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

		public Plant GetPlantByName(string name)
		{
			foreach (Plant plant in GetPlants())
			{
				if (plant.Name == name)
					return plant;
			}
			return null;
		}
	}
}
