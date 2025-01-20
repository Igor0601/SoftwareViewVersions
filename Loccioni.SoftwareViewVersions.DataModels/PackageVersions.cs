using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loccioni.SoftwareViewVersions.DataModels
{
	public class PackageVersions
	{
		public int Id { get; set; }
		public int IdBench { get; set; }
		public string Ref_Person { get; set; }
		public DateTime Date_Upload { get; set; }
		public List<Package> Packages { get; set; }
		public PackageVersions(int id, int idBench, string ref_Person, DateTime date_upload, List<Package> packages) 
		{
			Id = id;
			IdBench = idBench;
			Ref_Person = ref_Person;
			Date_Upload = date_upload;
			Packages = packages;
		}
	}
}
