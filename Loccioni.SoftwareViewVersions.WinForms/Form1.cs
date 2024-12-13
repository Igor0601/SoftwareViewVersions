using Microsoft.EntityFrameworkCore;
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
using Loccioni.SoftwareViewVersions.Services;
using Loccioni.SoftwareViewVersions.Db;
using Loccioni.SoftwareViewVersions.DataModels;

namespace Loccioni.SoftwareViewVersions.WinForms
{
	public partial class Form1 : Form
	{
		ClientService clientService;
		PlantService plantService;
		BenchService benchService;
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
			benchService = new BenchService();
			plantService = new PlantService(benchService);
			clientService = new ClientService(plantService);
			formSelezionaCliente = new FormSelezionaCliente();
			formSelezionaPlant = new FormSelezionaPlant();
			formGestisciCliente = new FormGestisciCliente(visualizza);
			formGestisciPlant = new FormGestisciPlant(visualizza);
			formGestisciBanco = new FormGestisciBanco(visualizza);
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
			byte[] clientLogo = null;
			clienteTag[0] = textBoxTagCliente.Text;
			
			clientService.AddClient(clienteNome, clienteRagioneFiscale, clienteTag);
			loadTreeView();
			formSelezionaCliente.loadListView(clientService);
			
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
			plantService.AddPlant(plantIdCliente, plantNome, plantNazione, plantCitta, plantIndirizzo, plantTag);
			loadTreeView();
			formSelezionaPlant.loadListView(plantService, clientService);
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
		private void ButtonAddBench_Click(object sender, EventArgs e)
		{
			formSelezionaPlant = new FormSelezionaPlant();
			formSelezionaPlant.loadListView(plantService, clientService);
			string bancoNome = textBoxNomeBanco.Text;
			string bancoUrlGit = textBoxUrlGitBanco.Text;
			string[] bancoTag = new string[1];
			bancoTag[0] = textBoxTagBanco.Text;
			formSelezionaPlant.ShowDialog();
			int bancoIdPlant = formSelezionaPlant.GetIdPlant();
			benchService.AddBench(bancoIdPlant, bancoNome, bancoUrlGit, bancoTag);
			loadTreeView();
			textBoxNomeBanco.Clear();
			textBoxUrlGitBanco.Clear();
			textBoxTagBanco.Clear();
		}
		private void loadTreeView()
		{
			treeView1.Nodes.Clear();
			foreach (Client client in clientService.GetClientes())
			{
				TreeNode clientNode = new TreeNode($"ID: {client.Id}, Nome: {client.Name}, Ragione fiscale: {client.RagioneFiscale}, Tag: {client.Tags[0]}")
				{
					Name = client.Id.ToString()
				};
				treeView1.Nodes.Add(clientNode);
				foreach (Plant plant in plantService.GetPlants())
				{
					if (plant.IdClient == client.Id)
					{
						TreeNode plantNode = new TreeNode($"ID: {plant.Id}, Nome: {plant.Name}, Nazione: {plant.State}, Citta: {plant.City}, Indirizzo: {plant.Address}, Tag: {plant.Tags[0]}")
						{
							Name = plant.Id.ToString()
						};
						clientNode.Nodes.Add(plantNode);
						foreach (Bench bench in benchService.GetBenches())
						{
							if (bench.IdPlant == plant.Id)
							{
								TreeNode benchNode = new TreeNode($"Id: {bench.Id}, Nome: {bench.Name}, UrlGit: {bench.UrlGit}, Tag: {bench.Tags[0]}");
								plantNode.Nodes.Add(benchNode);
							}
						}
					}
				}
			}
		}
		private void ButtonModificaCliente_Click(object sender, EventArgs e)
		{
			formGestisciCliente = new FormGestisciCliente(true);
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
			formGestisciPlant = new FormGestisciPlant(true);
			formGestisciPlant.loadListView(plantService, clientService);
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
			formGestisciBanco = new FormGestisciBanco(true);
			formGestisciBanco.loadListView(benchService, plantService, clientService);
			formGestisciBanco.ShowDialog();
			int IdBancoModificato = formGestisciBanco.GetId();
			string NomeBancoModificato = formGestisciBanco.GetNome();
			string UrlGitBancoModificato = formGestisciBanco.GetUrlGit();
			string[] TagBancoModificato = formGestisciBanco.GetTag();
			benchService.AggiornaBanco(IdBancoModificato, NomeBancoModificato, UrlGitBancoModificato, TagBancoModificato);
			loadTreeView();
		}
		private void ButtonDeleteBanco_Click(object sender, EventArgs e)
		{
			formGestisciBanco = new FormGestisciBanco(false);
			formGestisciBanco.loadListView(benchService, plantService, clientService);
			formGestisciBanco.ShowDialog();
			int idBenchDeleted = formGestisciBanco.GetId();
			benchService.DeleteBench(idBenchDeleted);
			loadTreeView();
		}
		private void ButtonDeletePlant_Click(object sender, EventArgs e)
		{
			formGestisciPlant = new FormGestisciPlant(false);
			formGestisciPlant.loadListView(plantService, clientService);
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