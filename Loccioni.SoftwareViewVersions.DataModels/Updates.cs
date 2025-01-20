using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Loccioni.SoftwareViewVersions.DataModels
{
	public class Updates
	{
		public int Id { get; set; }
		public int IdBench { get; set; }
		public string RefPerson { get; set; }
		public string DateUpload { get; set; }
		public List<string> Projects { get; set; }
		public Updates(int id, int idBench, string refPerson, string dateUpload, List<string> projects) 
		{
			Id = id;
			IdBench = idBench;
			RefPerson = refPerson;
			DateUpload = dateUpload;
			Projects = projects;
		}
	}
}
