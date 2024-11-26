using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loccioni.SoftwareViewVersions.Db;
using Loccioni.SoftwareViewVersions.DataModels;
using Loccioni.SoftwareViewVersions.Services;

namespace Loccioni.SoftwareViewVersions.WinForms
{
	public partial class FormGestisciBanco : Form
	{
		int id;
		string nome;
		string urlGit;
		string[] tag;
		FormModificaBanco formModificaBanco;
		public FormGestisciBanco(bool visualizza)
		{
			InitializeComponent();
			id = 0;
			nome = null;
			urlGit = null;
			tag = new string[1];
			formModificaBanco = new FormModificaBanco();
			if(visualizza == true)
				ButtonEliminaBanco.Visible = false;
			else
				ButtonModificaBanco.Visible = false;
		}
		public void loadListView(BenchService benchService, PlantService plantService, ClientService clientService)
		{
			listViewGestisciBanco.View = View.Details;
			listViewGestisciBanco.FullRowSelect = true;
			listViewGestisciBanco.GridLines = true;
			listViewGestisciBanco.Columns.Add($"ID: ", 50);
			listViewGestisciBanco.Columns.Add($"Nome: ", 150);
			listViewGestisciBanco.Columns.Add($"UrlGit: ", 150);
			listViewGestisciBanco.Columns.Add($"Tag: ", 50);
			listViewGestisciBanco.Columns.Add($"Plant: ", 150);
			listViewGestisciBanco.Columns.Add($"Cliente: ", 150);
			listViewGestisciBanco.Items.Clear();

			foreach (Bench bench in benchService.GetBenches())
			{
				ListViewItem bancoItem = new ListViewItem($"{bench.Id}")
				{
					Name = bench.Id.ToString()
				};
				bancoItem.SubItems.Add($"{bench.Name}");
				bancoItem.SubItems.Add($"{bench.UrlGit}");
				bancoItem.SubItems.Add($"{bench.Tags[0]}");
				foreach (Plant plant in plantService.GetPlants()) 
				{
					if (plant.Id == bench.IdPlant) 
					{
						bancoItem.SubItems.Add($"{plant.Name}");
						foreach (Client client in clientService.GetClientes())
						{
							if (client.Id == plant.IdClient)
							{
								bancoItem.SubItems.Add($"{client.Name}");
							}
						}
					}
				}
				listViewGestisciBanco.Items.Add(bancoItem);
			}
		}
		private void ButtonModificaBanco_Click(object sender, EventArgs e)
		{
			formModificaBanco = new FormModificaBanco();
			if (listViewGestisciBanco.SelectedItems.Count > 0)
			{
				ListView.SelectedListViewItemCollection selectedItem = listViewGestisciBanco.SelectedItems;
				formModificaBanco.loadTextBoxes(selectedItem);
				formModificaBanco.ShowDialog();
			}
			id = formModificaBanco.GetId();
			nome = formModificaBanco.GetNome();
			urlGit = formModificaBanco.GetUrlGit();
			tag = formModificaBanco.GetTag();
			this.Close();
		}
		public int GetId() { return id; }
		public string GetNome() { return nome; }
		public string GetUrlGit() { return urlGit; }
		public string[] GetTag() { return tag; }

		private void ButtonEliminaBanco_Click(object sender, EventArgs e)
		{
			if(listViewGestisciBanco.SelectedItems.Count > 0)
			{
				id = int.Parse(listViewGestisciBanco.SelectedItems[0].Text);
				nome = listViewGestisciBanco.SelectedItems[0].SubItems[1].Text;
				urlGit = listViewGestisciBanco.SelectedItems[0].SubItems[2].Text;
				tag[0] = listViewGestisciBanco.SelectedItems[0].SubItems[3].Text;
			}
			this.Close();
		}
	}
}
