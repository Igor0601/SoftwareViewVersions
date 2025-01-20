using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Loccioni.SoftwareViewVersions.DataModels;
using Loccioni.SoftwareViewVersions.Db;
using Loccioni.SoftwareViewVersions.Services;

namespace Loccioni.SoftwareViewVersions.Controllers.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
    
    public class ClientsController : ControllerBase
    {
        private ClientService _clientService;
        private PlantService _plantService;
        private BenchService _benchService;
        public ClientsController()
        {
            _benchService = new BenchService();
            _plantService = new PlantService(_benchService);
            _clientService = new ClientService(_plantService);
        }

        [HttpGet()]
        public List<Client> GetClients() 
        {
			return _clientService.GetClientes();
        }

		[HttpGet("logo")]
		public byte[] GetLogo() 
		{
			return _clientService.GetLogoClient();		
		}
		
        //GET: api/clients/name
        [HttpGet("name")]
        public Client GetClient(string name)
        {
            return _clientService.GetClientByName(name);
        }

		// PUT: api/Clients
		[HttpPut]
		public void PutClient(int id, string name, string ragioneFiscale, string[] tags)
		{
			_clientService.UploadClient(id, name, ragioneFiscale, tags);
		}

		// POST: api/Clients
		[HttpPost]
        public void PostClient(string name, string ragioneFiscale, ClientInfos infos)
        {
			byte[] fileBytes;
			using (var ms = new MemoryStream())
			{
				infos.file.CopyTo(ms);
				fileBytes = ms.ToArray();
			}
			_clientService.AddClient(name, ragioneFiscale, infos.tags, fileBytes);
		}

		// DELETE: api/Clients
		[HttpDelete]
        public void DeleteClient(int id)
        {
           _clientService.DeleteClient(id);        
        }
    }

    public class ClientInfos
    {
        public string[] tags { get; set; }
        public IFormFile file { get; set; }
    }
}
