namespace Prova
{
	public class Bench
	{
		public int id { get; set; }
		public int idPlant { get; set; }
		public string name { get; set; }
		public string urlGit { get; set; }

		public string[] tags { get; set; } = new string[10];

		public Bench(int id, int idPlant, string name, string urlGit, string[] tags)
		{
			this.id = id;
			this.idPlant = idPlant;
			this.name = name;
			this.urlGit = urlGit;
			this.tags = tags;
		}
	}
}
