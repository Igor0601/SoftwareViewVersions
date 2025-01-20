using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loccioni.SoftwareViewVersions.DataModels
{
	public class Package
	{
		public string Name { get; set; }
		public string Version { get; set; }
		public Package(string name, string version)
		{
			Name = name;
			Version = version;
		}
	}
}
