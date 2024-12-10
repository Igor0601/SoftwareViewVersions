using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loccioni.SoftwareViewVersions.DataModels
{
	public class Client
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string RagioneFiscale { get; set; }

		public string[] Tags { get; set; } = new string[10];
		public byte[] Logo { get; set; }

		public Client(int id, string name, string ragioneFiscale, string[] tags, byte[] logo)
		{
			Id = id;
			Name = name;
			RagioneFiscale = ragioneFiscale;
			Tags = tags;
			Logo = logo;
		}
	}
}
