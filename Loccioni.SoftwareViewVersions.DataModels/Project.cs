using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loccioni.SoftwareViewVersions.DataModels
{
	public class Project
	{
		public string Name { get; set; }
		public List<Package> Packages { get; set; }
		public Project(string name, List<Package> packages)
		{
			Name = name;
			Packages = packages;
		}
	}
}
