using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
	internal class Project
	{
		public string Name { get; set; }
		public List<Package> Packages { get; set; }
		public Project() { 
			Packages = new List<Package>();
		}
	}
}
