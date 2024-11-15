using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Windows.Forms;

namespace Prova
{
	public partial class Form1 : Form
	{
		ClientService clientService;
		PlantService plantService;
		BenchService bancoService;
		List<Client> clienti;
		List<Plant> plants;
		List<Bench> banchi;
		FormSelezionaCliente formSelezionaCliente;
		FormSelezionaPlant formSelezionaPlant;
		FormGestisciCliente formGestisciCliente;
		FormGestisciPlant formGestisciPlant;
		FormGestisciBanco formGestisciBanco;
		Random random = new Random();
		public bool visualizza;
		public Form1()
		{
			InitializeComponent();
			bancoService = new BenchService(plantService);
			clientService = new ClientService(plantService);
			plantService = new PlantService(bancoService, clientService);
			formSelezionaCliente = new FormSelezionaCliente();
			formSelezionaPlant = new FormSelezionaPlant();
			formGestisciCliente = new FormGestisciCliente(visualizza);
			formGestisciPlant = new FormGestisciPlant(visualizza);
			formGestisciBanco = new FormGestisciBanco(visualizza);
			clienti = clientService.GetClientes();
			plants = plantService.GetPlants();
			banchi = bancoService.GetBanchi();
		}
		private void ButtonTextBoxesClient_Click(object sender, EventArgs e)
		{
			string[] nome = new string[] { "Loccioni", "Ferrari", "Audi", "Trenitalia", "Lamborghini", "Bosch" };
			string[] ragioneFiscale = new string[] { "Spa", "Srls", "Srl", "Inc" };
			string[] tag = new string[] { "VIP" };

			//random.Next(nome.Length) -> Genera una lettura casuale della lunghezza dell' array di stringhe
			textBoxNomeCliente.Text = nome[random.Next(nome.Length)];
			textBoxRagioneFiscaleCliente.Text = $"{textBoxNomeCliente.Text} {ragioneFiscale[random.Next(ragioneFiscale.Length)]}";
			textBoxTagCliente.Text = tag[random.Next(tag.Length)];

		}
		private void ButtonAddClient_Click(object sender, EventArgs e)
		{
			string clienteNome = textBoxNomeCliente.Text;
			string clienteRagioneFiscale = textBoxRagioneFiscaleCliente.Text;
			string[] clienteTag = new string[1];
			clienteTag[0] = textBoxTagCliente.Text;
			if (clienti.Exists(p => p.Nome == clienteNome))
				MessageBox.Show("Errore, cliente già esistente");
			else
			{
				clientService.AddCliente(clienteNome, clienteRagioneFiscale, clienteTag);
				loadTreeView();
				formSelezionaCliente.loadListView(clientService);
			}
			textBoxNomeCliente.Clear();
			textBoxRagioneFiscaleCliente.Clear();
			textBoxTagCliente.Clear();
		}
		private void ButtonTextBoxesPlant_Click(object sender, EventArgs e)
		{
			string[] nome = new string[] { "Plant1", "Plant2", "Plant3", "Plant4", "Plant5" };
			string[] nazione = new string[] { "Italia", "Francia", "Germania", "Cina", "USA", "UK", "Vietnam", "Giappone", "UAE" };
			string[] citta = new string[] { "Maiolati Spontini", "Mioie", "Maranello", "Modena", "Bologna", "Roma", "Paris", "Berlin", "New York", "Beijing", "Shanghai", "Tokyo", "Kyoto", "Dubai", "Abu Dhabi" };
			string[] indirizzo = new string[] { "Via, 1", "Via, 2", "Via, 3", "Via, 4" };
			string[] tag = new string[] { "VIP" };

			textBoxNomePlant.Text = nome[random.Next(nome.Length)];
			textBoxNazionePlant.Text = nazione[random.Next(nazione.Length)];
			textBoxCittaPlant.Text = citta[random.Next(citta.Length)];
			textBoxIndirizzoPlant.Text = indirizzo[random.Next(indirizzo.Length)];
			textBoxTagPlant.Text = tag[random.Next(tag.Length)];
		}

		private void ButtonAddPlant_Click(object sender, EventArgs e)
		{
			//creo un nuovo oggetto di tipo FormSelezionaCliente
			formSelezionaCliente = new FormSelezionaCliente();

			//Gli passo l'oggetto clientService
			formSelezionaCliente.loadListView(clientService);

			string plantNome = textBoxNomePlant.Text;
			string plantNazione = textBoxNazionePlant.Text;
			string plantCitta = textBoxCittaPlant.Text;
			string plantIndirizzo = textBoxIndirizzoPlant.Text;
			string[] plantTag = new string[1];
			plantTag[0] = textBoxTagPlant.Text;
			formSelezionaCliente.ShowDialog();

			int plantIdCliente = formSelezionaCliente.GetIdClientes();

			plantService.AggiungiPlant(plantIdCliente, plantNome, plantNazione, plantCitta, plantIndirizzo, plantTag);

			loadTreeView();
			formSelezionaPlant.loadListView(plantService);

			textBoxNomePlant.Clear();
			textBoxNazionePlant.Clear();
			textBoxCittaPlant.Clear();
			textBoxIndirizzoPlant.Clear();
			textBoxTagPlant.Clear();
		}
		private void ButtonTextBoxesBanco_Click(object sender, EventArgs e)
		{
			string[] nome = new string[] { "Banco1", "Banco2", "Banco3", "Banco4", "Banco5", "Banco6" };
			string[] urlGit = new string[] { "url1", "url2", "url3", "url4", "url5", "url6" };
			string[] tag = new string[] { "VIP" };

			textBoxNomeBanco.Text = nome[random.Next(nome.Length)];
			textBoxUrlGitBanco.Text = urlGit[random.Next(urlGit.Length)];
			textBoxTagBanco.Text = tag[random.Next(tag.Length)];
		}
		private void ButtonAddBanco_Click(object sender, EventArgs e)
		{
			formSelezionaPlant = new FormSelezionaPlant();
			formSelezionaPlant.loadListView(plantService);
			string bancoNome = textBoxNomeBanco.Text;
			string bancoUrlGit = textBoxUrlGitBanco.Text;
			string[] bancoTag = new string[1];
			bancoTag[0] = textBoxTagBanco.Text;
			if (banchi.Exists(b => b.Nome == bancoNome))
				MessageBox.Show("Errore, banco già esistente");
			else
			{
				formSelezionaPlant.ShowDialog();
				int bancoIdPlant = formSelezionaPlant.GetIdPlant();

				bancoService.AggiungiBanco(bancoIdPlant, bancoNome, bancoUrlGit, bancoTag);
				loadTreeView();
			}
			textBoxNomeBanco.Clear();
			textBoxUrlGitBanco.Clear();
			textBoxTagBanco.Clear();
		}
		private void loadTreeView()
		{
			treeView1.Nodes.Clear();
			foreach (Client cliente in clienti)
			{
				TreeNode clienteNode = new TreeNode($"ID: {cliente.Id}, Nome: {cliente.Nome}, Ragione fiscale: {cliente.RagioneFiscale}, Tag: {cliente.Tags[0]}")
				{
					Name = cliente.Id.ToString()
				};
				treeView1.Nodes.Add(clienteNode);
				foreach (Plant plant in plants)
				{
					if (plant.IdCliente == cliente.Id)
					{
						TreeNode plantNode = new TreeNode($"ID: {plant.Id}, Nome: {plant.Nome}, Nazione: {plant.Nazione}, Citta: {plant.Citta}, Indirizzo: {plant.Indirizzo}, Tag: {plant.Tags[0]}")
						{
							Name = plant.Id.ToString()
						};
						clienteNode.Nodes.Add(plantNode);
						foreach (Bench banco in banchi)
						{
							if (banco.IdPlant == plant.Id)
							{
								TreeNode bancoNode = new TreeNode($"Id: {banco.Id}, Nome: {banco.Nome}, UrlGit: {banco.UrlGit}, Tag: {banco.Tags[0]}");
								plantNode.Nodes.Add(bancoNode);
							}
						}
					}
				}
			}
		}
		private void ButtonModificaCliente_Click(object sender, EventArgs e)
		{
			visualizza = true;
			formGestisciCliente = new FormGestisciCliente(visualizza);
			formGestisciCliente.loadListView(clientService);
			formGestisciCliente.ShowDialog();
			int IdClienteModificato = formGestisciCliente.GetId();
			string NomeClienteModificato = formGestisciCliente.GetNome();
			string RagioneFiscaleClienteModificato = formGestisciCliente.GetRagioneFiscale();
			string[] TagClienteModificato = formGestisciCliente.GetTag();
			clientService.AggiornaCliente(IdClienteModificato, NomeClienteModificato, RagioneFiscaleClienteModificato, TagClienteModificato);
			loadTreeView();
		}
		private void ButtonGestisciPlant_Click(object sender, EventArgs e)
		{
			visualizza = true;
			formGestisciPlant = new FormGestisciPlant(visualizza);
			formGestisciPlant.loadListView(plantService);
			formGestisciPlant.ShowDialog();
			int IdPlantModificato = formGestisciPlant.GetId();
			string NomePlantModificato = formGestisciPlant.GetNome();
			string NazionePlantModificato = formGestisciPlant.GetNazione();
			string CittaPlantModificato = formGestisciPlant.GetCitta();
			string IndirizzoPlantModificato = formGestisciPlant.GetIndirizzo();
			string[] TagPlantModificato = formGestisciPlant.GetTag();
			plantService.AggiornaPlant(IdPlantModificato, NomePlantModificato, NazionePlantModificato, CittaPlantModificato, IndirizzoPlantModificato, TagPlantModificato);
			loadTreeView();
		}
		private void ButtonGestisciBanco_Click(object sender, EventArgs e)
		{
			visualizza = true;
			formGestisciBanco = new FormGestisciBanco(visualizza);
			formGestisciBanco.loadListView(bancoService);
			formGestisciBanco.ShowDialog();
			int IdBancoModificato = formGestisciBanco.GetId();
			string NomeBancoModificato = formGestisciBanco.GetNome();
			string UrlGitBancoModificato = formGestisciBanco.GetUrlGit();
			string[] TagBancoModificato = formGestisciBanco.GetTag();
			bancoService.AggiornaBanco(IdBancoModificato, NomeBancoModificato, UrlGitBancoModificato, TagBancoModificato);
			loadTreeView();
		}
		private void ButtonDeleteBanco_Click(object sender, EventArgs e)
		{
			visualizza = false;
			formGestisciBanco = new FormGestisciBanco(visualizza);
			formGestisciBanco.loadListView(bancoService);
			formGestisciBanco.ShowDialog();
			int idBancDeleted = formGestisciBanco.GetId();
			bancoService.DeleteBanco(idBancDeleted);
			loadTreeView();
		}
		private void ButtonDeletePlant_Click(object sender, EventArgs e)
		{
			visualizza = false;
			formGestisciPlant = new FormGestisciPlant(visualizza);
			formGestisciPlant.loadListView(plantService);
			formGestisciPlant.ShowDialog();
			int idPlantDeleted = formGestisciPlant.GetId();
			plantService.DeletePlant(idPlantDeleted);
			loadTreeView();
		}
		private void ButtonDeleteClient_Click(object sender, EventArgs e)
		{
			
			formGestisciCliente = new FormGestisciCliente(false);
			formGestisciCliente.loadListView(clientService);
			formGestisciCliente.ShowDialog();
			int idClientDeleted = formGestisciCliente.GetId();
			clientService.DeleteClient(idClientDeleted);
			loadTreeView();
		}
	}
}