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

    public class PlantsController : ControllerBase
    {
        private PlantService _plantService;
        private BenchService _benchService;

        public PlantsController()
        {
            _benchService = new BenchService();
           _plantService = new PlantService(_benchService);
        }

        // GET: api/Plants
        [HttpGet]
        public List<Plant> Getplants()
        {
            return _plantService.GetPlants();
        }

        // PUT: api/Plants
        [HttpPut]
        public void PutPlant(int id, string name, string state, string city, string address, string[] tag)
        {
            _plantService.AggiornaPlant(id, name, state, city, address, tag);
        }

        // POST: api/Plants
        [HttpPost]
        public void PostPlant(int idClient, string name, string state, string city, string address, string[] tag)
        {
            _plantService.AddPlant(idClient, name, state, city, address, tag);
        }

        // DELETE: api/Plants/5
        [HttpDelete("{id}")]
        public void DeletePlant(int id)
        {
            _plantService.DeletePlant(id);
        }
    }
}
