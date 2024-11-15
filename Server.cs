using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
	public class Server
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int PlantId { get; set; }
		public string Versione { get; set; }
		public string Supervisor { get; set; }
		public string Configurator { get; set; }
		public string WorkerHealth { get; set; }
		public string WorkerModels { get; set; }
		public string WorkerPrograms { get; set; }
		public string WorkerResource { get; set; }
		public string WorkerResults { get; set; }
		public string WorkerTopology { get; set; }
		public string WorkerWip { get; set; }
		public string UploaderHealth { get; set; }
		public string UploaderReport { get; set; }
		public string Link { get; set; }
		public string Tags { get; set; }
		public Server(int id, string nome, int plantId, string versione, string supervisor, string configurator, string workerHealth, string workerModels, string workerPrograms, string workerResource, string workerResults, string workerTopology, string workerWip, string uploaderHealth, string uploaderReport, string link, string tags)
		{
			Id = id;
			Nome = nome;
			PlantId = plantId;
			Versione = versione;
			Supervisor = supervisor;
			Configurator = configurator;
			WorkerHealth = workerHealth;
			WorkerModels = workerModels;
			WorkerPrograms = workerPrograms;
			WorkerResource = workerResource;
			WorkerResults = workerResults;
			WorkerTopology = workerTopology;
			WorkerWip = workerWip;
			UploaderHealth = uploaderHealth;
			UploaderReport = uploaderReport;
			Link = link;
			Tags = tags;
		}
	}
}
