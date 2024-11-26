using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loccioni.SoftwareViewVersions.DataModels;
using Loccioni.SoftwareViewVersions.Db;
using Loccioni.SoftwareViewVersions.Services;

namespace Loccioni.SoftwareViewVersions.WinForms
{
	public partial class FormSelezionaPlant : Form
	{
		int idPlant;
		public FormSelezionaPlant()
		{
			InitializeComponent();
		}
		public void loadListView(PlantService plantService, ClientService clientService) 
		{
			listViewPlants.View = View.Details;
			listViewPlants.FullRowSelect = true;
			listViewPlants.GridLines = true;
			listViewPlants.Columns.Add($"Id: ", 50);
			listViewPlants.Columns.Add($"Nome: ", 50);
			listViewPlants.Columns.Add($"Cliente: ", 150);
			listViewPlants.Items.Clear();
			foreach (Plant plant in plantService.GetPlants()) 
			{
				ListViewItem plantItem = new ListViewItem($"{plant.Id}")
				{
					Name = plant.Id.ToString()
				};
				plantItem.SubItems.Add(plant.Name);
				foreach (Client client in clientService.GetClientes())
				{
					if (client.Id == plant.IdClient) 
						plantItem.SubItems.Add(client.Name);
				}
				listViewPlants.Items.Add(plantItem);
			}
		}
		private void ButtonSelezionaPlant_Click(object sender, EventArgs e)
		{
			if(listViewPlants.SelectedItems.Count > 0) 
			{
				idPlant = int.Parse(listViewPlants.SelectedItems[0].Text);
			}
			this.Close();
		}
		public int GetIdPlant() 
		{
			return idPlant;
		}
	}
}
