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
	public partial class FormModificaPlant : Form
	{
		int id;
		string nome;
		string nazione;
		string citta;
		string indirizzo;
		string[] tag = new string[1];
		public FormModificaPlant()
		{
			InitializeComponent();
		}
		internal void loadTextBoxes(ListView.SelectedListViewItemCollection selectedItem)
		{
			id = int.Parse(selectedItem[0].Text);
			textBoxNomePlantModificato.Text = selectedItem[0].SubItems[1].Text;
			textBoxNazionePlantModificato.Text = selectedItem[0].SubItems[2].Text;
			textBoxCittaPlantModificato.Text = selectedItem[0].SubItems[3].Text;
			textBoxIndirizzoPlantModificato.Text = selectedItem[0].SubItems[4].Text;
			textBoxTagPlantModificato.Text = selectedItem[0].SubItems[5].Text;
		}
		public void ButtonModificaPlant_Click(object sender, EventArgs e)
		{
			nome = textBoxNomePlantModificato.Text;
			nazione = textBoxNazionePlantModificato.Text;
			citta = textBoxCittaPlantModificato.Text;
			indirizzo = textBoxIndirizzoPlantModificato.Text;
			tag[0] = textBoxTagPlantModificato.Text;

			this.Close();
		}
		public int GetId() {  return id; }
		public string GetNome() { return nome; }
		public string GetNazione() {  return nazione; }
		public string GetCitta() {  return citta; }
		public string GetIndirizzo() {  return indirizzo; }
		public string[] GetTag() { return tag; }
	}
}
