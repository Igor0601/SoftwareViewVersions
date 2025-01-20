using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loccioni.SoftwareViewVersions.DataModels
{
	public class Server
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int IdPlant { get; set; }
		public string UrlGit { get; set; }
		
		public Server(int id, string name, int idPlant, string urlGit)
		{
			Id = id;
			Name = name;
			IdPlant = idPlant;
			UrlGit = urlGit;
		}
	}
}
