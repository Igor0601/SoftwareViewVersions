using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Prova
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
				if (clientId == client.id)
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
				if(client.name == name)
				{
					MessageBox.Show("Errore, Cliente già esistente");
				}
			}
		}
		public void AggiornaCliente(int IdClienteModificato, string NomeClienteModificato, string RagioneFiscaleClienteModificato, string[] TagClienteModificato) 
		{
			Client clienteDaModificare = ldb.clients.FirstOrDefault(c => c.id == IdClienteModificato);
			if (clienteDaModificare != null) 
			{
				clienteDaModificare.name = NomeClienteModificato;
				clienteDaModificare.ragioneFiscale = RagioneFiscaleClienteModificato;
				clienteDaModificare.tags = TagClienteModificato;	
			}
			//ldb.Update(new Client(clienteDaModificare.id, clienteDaModificare.name, clienteDaModificare.ragioneFiscale, clienteDaModificare.tags));
			ldb.SaveChanges();
		}
		public void DeleteClient(int idClientDeleted) 
		{
			Client client = ldb.clients.FirstOrDefault(c => c.id == idClientDeleted);
			if(client != null)
			{
				plantService.Delete(idClientDeleted);
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
