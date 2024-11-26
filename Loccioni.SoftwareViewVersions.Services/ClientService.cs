﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loccioni.SoftwareViewVersions.DataModels;
using Loccioni.SoftwareViewVersions.Db;

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
		public void AddClient(string clientName, string clientRagioneFiscale, string[] clientTag)
		{
			clientId++;
			foreach (Client client in ldb.clients)
			{
				if (clientId == client.Id)
				{
					clientId++;
				}
			}
			Add(clientName);
			ldb.Add(new Client(clientId, clientName, clientRagioneFiscale, clientTag));
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
		public void AggiornaCliente(int IdClienteModificato, string NomeClienteModificato, string RagioneFiscaleClienteModificato, string[] TagClienteModificato)
		{
			Client clienteDaModificare = ldb.clients.FirstOrDefault(c => c.Id == IdClienteModificato);
			if (clienteDaModificare != null)
			{
				clienteDaModificare.Name = NomeClienteModificato;
				clienteDaModificare.RagioneFiscale = RagioneFiscaleClienteModificato;
				clienteDaModificare.Tags = TagClienteModificato;
			}
			ldb.SaveChanges();
		}
		public void DeleteClient(int idClientDeleted)
		{
			Client client = ldb.clients.FirstOrDefault(c => c.Id == idClientDeleted);
			if (client != null)
			{
				plantService.Delete(client.Id);
				ldb.Remove(client);
				ldb.SaveChanges();
			}
		}
		public LoccioniDbContext GetClientes()
		{
			return ldb;
		}
	}
}