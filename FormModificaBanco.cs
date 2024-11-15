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
	public partial class FormModificaBanco : Form
	{
		int id;
		string nome;
		string urlGit;
		string[] tag = new string[1];
		public FormModificaBanco()
		{
			InitializeComponent();
		}
		public void loadTextBoxes(ListView.SelectedListViewItemCollection selectedItems) 
		{
			id = int.Parse(selectedItems[0].Text);
			textBoxNomeBancoModificato.Text = selectedItems[0].SubItems[1].Text;
			textBoxUrlGitBancoModificato.Text = selectedItems[0].SubItems[2].Text;
			textBoxTagBancoModificato.Text = selectedItems[0].SubItems[3].Text;

		}
		public void ButtonModificaBanco_Click(object sender, EventArgs e)
		{
			nome = textBoxNomeBancoModificato.Text;
			urlGit = textBoxUrlGitBancoModificato.Text;
			tag[0] = textBoxTagBancoModificato.Text;
			this.Close();
		}
		public int GetId() {return id;}
		public string GetNome() { return nome;}
		public string GetUrlGit() {return urlGit;}
		public string[] GetTag() {return tag;}
	}
}
