using EnvDTE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace Loccioni.SoftwareViewVersions.WinForms
{
	public partial class FormModificaCliente : Form
	{
		int IdClienteModificato;
		string NomeClienteModificato;
		string RagioneFiscaleClienteModificato;
		string[] TagClienteModificato = new string[1];
		public FormModificaCliente()
		{
			InitializeComponent();
		}
		internal void loadTextBoxes(ListView.SelectedListViewItemCollection selectedItems)
		{
			IdClienteModificato = int.Parse(selectedItems[0].Text);
			textBoxNomeClienteModifica.Text = selectedItems[0].SubItems[1].Text;
			textBoxRagioneFiscaleClienteModifica.Text = selectedItems[0].SubItems[2].Text;
			textBoxTagClienteModifica.Text = selectedItems[0].SubItems[3].Text;
		}
		public void ButtonModificaCliente_Click(object sender, EventArgs e)
		{
			NomeClienteModificato = textBoxNomeClienteModifica.Text;
			RagioneFiscaleClienteModificato = textBoxRagioneFiscaleClienteModifica.Text;
			TagClienteModificato[0] = textBoxTagClienteModifica.Text;

			this.Close();
		}
		public int GetId() {return IdClienteModificato;}
		public string GetNome() {return NomeClienteModificato;}
		public string GetRagioneFiscale() {return RagioneFiscaleClienteModificato;}
		public string[] GetTag() {return TagClienteModificato;}
	}
}
