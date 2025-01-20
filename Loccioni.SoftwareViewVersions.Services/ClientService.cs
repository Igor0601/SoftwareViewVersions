﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loccioni.SoftwareViewVersions.DataModels;
using Loccioni.SoftwareViewVersions.Db;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Loccioni.SoftwareViewVersions.Services
{
	public class ClientService
	{
		public int clientId;
		LoccioniDbContext ldb;
		PlantService plantService;

		public ClientService(PlantService plantService)
		{
			this.plantService = plantService;
			ldb = new LoccioniDbContext();
		}

		public LoccioniDbContext LoccioniDbContext
		{
			get => default;
			set
			{
			}
		}

		public void AddClient(string name, string ragioneFiscale, string[] tags, byte[] logo)
		{
			clientId++;
			foreach (Client client in ldb.clients)
			{
				if (clientId == client.Id)
				{
					clientId++;
				}
			}
			Add(name);
			ldb.Add(new Client(clientId, name, ragioneFiscale, tags, logo));
			ldb.SaveChanges();
		}
		public void Add(string name)
		{
			foreach (Client client in ldb.clients)
			{
				if (client.Name == name)
					throw new Exception("Errore, Cliente già esistente");
			}
		}
		public void UploadClient(int id, string name, string ragioneFiscale, string[] tag)
		{
			Client clienteDaModificare = ldb.clients.FirstOrDefault(c => c.Id == id);
			if (clienteDaModificare != null)
			{
				clienteDaModificare.Name = name;
				clienteDaModificare.RagioneFiscale = ragioneFiscale;
				clienteDaModificare.Tags = tag;
			}
			ldb.SaveChanges();
		}
		public void DeleteClient(int id)
		{
			Client client = ldb.clients.FirstOrDefault(c => c.Id == id);
			if (client != null)
			{
				plantService.Delete(client.Id);
				ldb.Remove(client);
				ldb.SaveChanges();
			}
		}
		public List<Client> GetClientes()
		{
			return ldb.clients.ToList();
		}
		public byte[] GetLogoClient()
		{
			byte[] logoClient =  null;
			foreach (Client client in ldb.clients)
			{
				logoClient = client.Logo;
			}
			return logoClient;
		}
		
		public Client GetClientByName(string name) 
		{
			foreach (Client client in GetClientes())
			{
				if (client.Name == name)
					return client;
			}
			return null;
		}
	}
}
