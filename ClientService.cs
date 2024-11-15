using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
	public class ClientService
	{
		public List<Client> clients;
		public int clientId;
		PlantService plantService;

		public ClientService(PlantService plantService) 
		{
			this.clients = new List<Client>();
			this.plantService = plantService;
		}

		public void AddCliente(string clienteNome, string clienteRagioneFiscale, string[] clienteTag) 
		{
			Add(clienteNome);
			clientId++;
			Client newClient = new Client(clientId, clienteNome, clienteRagioneFiscale, clienteTag);
			clients.Add(newClient);
		}
		public void Add(string name) 
		{
			foreach (Client client in clients) 
			{ 
				if(client.name == name)
				{
					MessageBox.Show("Errore, Cliente già esistente");
				}
			}
		}
		public void AggiornaCliente(int IdClienteModificato, string NomeClienteModificato, string RagioneFiscaleClienteModificato, string[] TagClienteModificato) 
		{
			Client clienteDaModificare = clients.FirstOrDefault(c => c.id == IdClienteModificato);
			if (clienteDaModificare != null) 
			{
				clienteDaModificare.name = NomeClienteModificato;
				clienteDaModificare.ragioneFiscale = RagioneFiscaleClienteModificato;
				clienteDaModificare.tags = TagClienteModificato;	
			}
		}
		public void DeleteClient(int idClientDeleted) 
		{
			Client client = clients.FirstOrDefault(c => c.id == idClientDeleted);
			if(client != null)
			{
				plantService.Delete(idClientDeleted);
				clients.Remove(client);
			}
		}
		public List<Client> GetClientes()
		{
			return clients;
		}
	}
}
