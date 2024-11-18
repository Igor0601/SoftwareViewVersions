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
		public void loadListView(LoccioniDbContext ldb)
		{
			listViewGestisciBanco.View = View.Details;
			listViewGestisciBanco.FullRowSelect = true;
			listViewGestisciBanco.GridLines = true;
			listViewGestisciBanco.Columns.Add($"ID: ", 50);
			listViewGestisciBanco.Columns.Add($"Nome: ", 150);
			listViewGestisciBanco.Items.Clear();

			foreach (Bench bench in ldb.benches)
			{
				ListViewItem bancoItem = new ListViewItem($"{bench.id}")
				{
					Name = bench.id.ToString()
				};
				bancoItem.SubItems.Add($"{bench.name}");
				bancoItem.SubItems.Add($"{bench.urlGit}");
				bancoItem.SubItems.Add($"{bench.tags[0]}");
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
