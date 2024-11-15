namespace Prova
{
	public class Client
	{
		public int id { get; set; }
		public string name { get; set; }
		public string ragioneFiscale { get; set; }

		public string[] tags = new string[10];

		public Client(int id, string name, string ragioneFiscale, string[] tags)
		{
			this.id = id;
			this.name = name;
			this.ragioneFiscale = ragioneFiscale;
			this.tags = tags;
		}
	}
}
