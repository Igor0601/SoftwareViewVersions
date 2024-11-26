using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loccioni.SoftwareViewVersions.DataModels
{
	public class Plant
	{
		//Tutto con la iniziale grande
		public int Id { get; set; }
		public int IdClient { get; set; }
		public string Name { get; set; }
		public string State { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		public string[] Tags { get; set; } = new string[10];
		public Plant(int id, int idClient, string name, string state, string city, string address, string[] tags)
		{
			Id = id;
			IdClient = idClient;
			Name = name;
			State = state;
			City = city;
			Address = address;
			Tags = tags;
		}
	}
}
