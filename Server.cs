using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
	public class Server
	{
		public int id { get; set; }
		public string name { get; set; }
		public int plantId { get; set; }
		public string version { get; set; }
		public string supervisor { get; set; }
		public string configurator { get; set; }
		public string workerHealth { get; set; }
		public string workerModels { get; set; }
		public string workerPrograms { get; set; }
		public string workerResource { get; set; }
		public string workerResults { get; set; }
		public string workerTopology { get; set; }
		public string workerWip { get; set; }
		public string uploaderHealth { get; set; }
		public string uploaderReport { get; set; }
		public string link { get; set; }
		public string[] tags = new string[10];
		public Server(int id, string name, int plantId, string version, string supervisor, string configurator, string workerHealth, string workerModels, string workerPrograms, string workerResource, string workerResults, string workerTopology, string workerWip, string uploaderHealth, string uploaderReport, string link, string[] tags)
		{
			this.id = id;
			this.name = name;
			this.plantId = plantId;
			this.version = version;
			this.supervisor = supervisor;
			this.configurator = configurator;
			this.workerHealth = workerHealth;
			this.workerModels = workerModels;
			this.workerPrograms = workerPrograms;
			this.workerResource = workerResource;
			this.workerResults = workerResults;
			this.workerTopology = workerTopology;
			this.workerWip = workerWip;
			this.uploaderHealth = uploaderHealth;
			this.uploaderReport = uploaderReport;
			this.link = link;
			this.tags = tags;
		}
	}
}
