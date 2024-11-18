namespace Prova
{
	public class Plant
	{
		public int id { get; set; }
		public int idClient { get; set; }
		public string name { get; set; }
		public string state { get; set; }
		public string city { get; set; }
		public string address { get; set; }
		public string[] tags { get; set; } = new string[10];
		public Plant(int id, int idClient, string name, string state, string city, string address, string[] tags)
		{
			this.id = id;
			this.idClient = idClient;
			this.name = name;
			this.state = state;
			this.city = city;
			this.address = address;
			this.tags = tags;
		}
	}
}
