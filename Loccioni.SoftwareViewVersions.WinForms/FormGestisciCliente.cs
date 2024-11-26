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
	public partial class FormGestisciCliente : Form
	{
		FormModificaCliente formModificaCliente;
		int id;
		string name;
		string ragioneFiscale;
		string[] tag;

		public FormGestisciCliente(bool visualizza)
		{
			InitializeComponent();
			formModificaCliente = new FormModificaCliente();
			if(visualizza == true)
				ButtonEliminaCliente.Visible = false;
			else
				ButtonModificaCliente.Visible = false;
		}
		public void loadListView(ClientService clientService)
		{
			listViewGestisciCliente.View = View.Details;
			listViewGestisciCliente.FullRowSelect = true;
			listViewGestisciCliente.GridLines = true;
			listViewGestisciCliente.Columns.Add("ID", 50);
			listViewGestisciCliente.Columns.Add("Nome", 150);
			listViewGestisciCliente.Columns.Add("Ragione Fiscale: ", 150);
			listViewGestisciCliente.Columns.Add("Tag: ", 50);
			listViewGestisciCliente.Items.Clear();

			foreach (Client client in clientService.GetClientes())
			{
				ListViewItem clientItem = new ListViewItem($"{client.Id}")
				{
					Name = client.Id.ToString()
				};
				clientItem.SubItems.Add($"{client.Name}");
				clientItem.SubItems.Add($"{client.RagioneFiscale}");
				clientItem.SubItems.Add($"{client.Tags[0]}");
				listViewGestisciCliente.Items.Add(clientItem);
			}
		}
		public void ButtonModificaCliente_Click(object sender, EventArgs e)
		{
			formModificaCliente = new FormModificaCliente();
			if (listViewGestisciCliente.SelectedItems.Count > 0)
			{
				ListView.SelectedListViewItemCollection selectedItems = listViewGestisciCliente.SelectedItems;
				formModificaCliente.loadTextBoxes(selectedItems);
				formModificaCliente.ShowDialog();
			}
			id = formModificaCliente.GetId();
			name = formModificaCliente.GetNome();
			ragioneFiscale = formModificaCliente.GetRagioneFiscale();
			tag = formModificaCliente.GetTag();
			this.Close();
		}
		public int GetId() {return id;}
		public string GetNome() {return name;}
		public string GetRagioneFiscale() {return ragioneFiscale;}
		public string[] GetTag() {return tag;}

		public void ButtonEliminaCliente_Click(object sender, EventArgs e)
		{
			if(listViewGestisciCliente.SelectedItems.Count>0)
			{
				id = int.Parse(listViewGestisciCliente.SelectedItems[0].Text);
			}
			this.Close();
		}
	}
}
