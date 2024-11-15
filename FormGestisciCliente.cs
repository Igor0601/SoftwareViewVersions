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
	public partial class FormGestisciCliente : Form
	{
		FormModificaCliente formModificaCliente;
		int id;
		string nome;
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
			listViewGestisciCliente.Items.Clear();

			foreach (Client cliente in clientService.GetClientes())
			{
				ListViewItem clienteItem = new ListViewItem($"{cliente.Id}")
				{
					Name = cliente.Id.ToString()
				};
				clienteItem.SubItems.Add($"{cliente.Nome}");
				clienteItem.SubItems.Add($"{cliente.RagioneFiscale}");
				clienteItem.SubItems.Add($"{cliente.Tags[0]}");
				listViewGestisciCliente.Items.Add(clienteItem);
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
			nome = formModificaCliente.GetNome();
			ragioneFiscale = formModificaCliente.GetRagioneFiscale();
			tag = formModificaCliente.GetTag();
			this.Close();
		}
		public int GetId() {return id;}
		public string GetNome() {return nome;}
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
