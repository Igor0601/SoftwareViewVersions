﻿using System;
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
    [Route("api/[controller]")]
    [ApiController]
    public class BenchesController : ControllerBase
    {
        private BenchService _benchService;

        public BenchesController()
        {
            _benchService = new BenchService();
        }

        // GET: api/Benches
        [HttpGet]
        public List<Bench> Getbenches()
        {
            return _benchService.GetBenches();
        }

		//GET: api/Benches/name
		[HttpGet("name")]
		public Bench GetBench(string name)
		{
			return _benchService.GetBenchByName(name);
		}

		// PUT: api/Benches

		[HttpPut]
        public void PutBench(int id, string name, string urlGit, string[] tag)
        {
           _benchService.UploadBench(id, name, urlGit, tag);
        }

        // POST: api/Benches
        [HttpPost]
        public void PostBench(int idPlant, string name, string urlGit, BenchInfos infos)
        {
			byte[] fileBytes;
			using (var ms = new MemoryStream())
			{
				infos.file.CopyTo(ms);
				fileBytes = ms.ToArray();
			}
			_benchService.AddBench(idPlant, name, urlGit, infos.tags, fileBytes);
        }

        // DELETE: api/Benches/5
        [HttpDelete("{id}")]
        public void DeleteBench(int id)
        {
           _benchService.DeleteBench(id); 
        }

		public class BenchInfos
		{
			public string[] tags { get; set; }
			public IFormFile file { get; set; }
		}
	}
}
