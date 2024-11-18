using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
	public partial class FormSelezionaPlant : Form
	{
		int idPlant;
		public FormSelezionaPlant()
		{
			InitializeComponent();
		}
		public void loadListView(LoccioniDbContext ldb) 
		{
			listViewPlants.View = View.Details;
			listViewPlants.FullRowSelect = true;
			listViewPlants.GridLines = true;
			listViewPlants.Columns.Add($"ID: ", 50);
			listViewPlants.Columns.Add($"Nome: ", 150);
			listViewPlants.Items.Clear();

			foreach (Plant plant in ldb.plants) 
			{
				ListViewItem plantItem = new ListViewItem($"{plant.id}")
				{
					Name = plant.id.ToString()
				};
				plantItem.SubItems.Add($"{plant.name}");
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
