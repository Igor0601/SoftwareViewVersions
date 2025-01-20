using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loccioni.SoftwareViewVersions.DataModels
{
	public class ServerVersions
	{
		public int Id { get; set; }
		public int IdServer { get; set; }
		public string Version { get; set; }
		public string Supervisor { get; set; }
		public string Configurator { get; set; }
		public string Worker_Health { get; set; }
		public string Worker_Models { get; set; }
		public string Worker_Programs { get; set; }
		public string Worker_Resource { get; set; }
		public string Worker_Results { get; set; }
		public string Worker_Topology { get; set; }
		public string Worker_Wip { get; set; }
		public string Uploader_Health { get; set; }
		public string Uploader_Report { get; set; }
		public string Link { get; set; }
		public string[] Tags { get; set; }
		public string Ref_Person { get; set; }
		public DateTime Date_Upload { get; set; }
		public ServerVersions(int id, int idServer, string version, string supervisor, string configrator, string worker_health, string worker_models, string worker_programs, string worker_resource, string worker_results, string worker_topology, string worker_wip, string uploader_health, string uploader_report, string link, string[] tags, string ref_person, DateTime date_upload) 
		{
			Id = id;
			IdServer = idServer;
			Version = version;
			Supervisor = supervisor;
			Configurator = configrator;
			Worker_Health = worker_health;
			Worker_Models = worker_models;
			Worker_Programs = worker_programs;
			Worker_Resource = worker_resource;
			Worker_Results = worker_results;
			Worker_Topology = worker_topology;
			Worker_Wip = worker_wip;
			Uploader_Health = uploader_health;
			Uploader_Report = uploader_report;
			Link = link;
			Tags = tags;
			Ref_Person = ref_person;
			Date_Upload = date_upload;
		}
	}
}
