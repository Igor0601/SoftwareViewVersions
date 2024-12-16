using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loccioni.SoftwareViewVersions.DataModels
{
	public class Bench
	{
		public int Id { get; set; }
		public int IdPlant { get; set; }
		public string Name { get; set; }
		public string UrlGit { get; set; }

		public string[] Tags { get; set; }
		public byte[] Logo { get; set; }

		public Bench(int id, int idPlant, string name, string urlGit, string[] tags, byte[] logo)
		{
			Id = id;
			IdPlant = idPlant;
			Name = name;
			UrlGit = urlGit;
			Tags = tags;
			Logo = logo;
		}
	}
}
