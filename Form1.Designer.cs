namespace Prova
{
	public partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label CLIENTE;
		private System.Windows.Forms.Label NomeCliente;
		private System.Windows.Forms.Label RagioneFiscaleCliente;
		private System.Windows.Forms.Label TagCliente;
		private System.Windows.Forms.TextBox textBoxNomeCliente;
		private System.Windows.Forms.TextBox textBoxRagioneFiscaleCliente;
		private System.Windows.Forms.TextBox textBoxTagCliente;
		private System.Windows.Forms.Label PLANT;
		private System.Windows.Forms.Label NomePlant;
		private System.Windows.Forms.Label NazionePlant;
		private System.Windows.Forms.Label CittaPlant;
		private System.Windows.Forms.Label IndirizzoPlant;
		private System.Windows.Forms.Label TagPlant;
		private System.Windows.Forms.TextBox textBoxNomePlant;
		private System.Windows.Forms.TextBox textBoxNazionePlant;
		private System.Windows.Forms.TextBox textBoxCittaPlant;
		private System.Windows.Forms.TextBox textBoxIndirizzoPlant;
		private System.Windows.Forms.TextBox textBoxTagPlant;
		private System.Windows.Forms.Label BANCO;
		private System.Windows.Forms.Label NomeBanco;
		private System.Windows.Forms.Label urlGitBanco;
		private System.Windows.Forms.Label tagBanco;
		private System.Windows.Forms.TextBox textBoxNomeBanco;
		private System.Windows.Forms.TextBox textBoxUrlGitBanco;
		private System.Windows.Forms.TextBox textBoxTagBanco;
		private System.Windows.Forms.Button ButtonAggiungiCliente;
		private System.Windows.Forms.Button ButtonAggiungiPlant;
		private System.Windows.Forms.Button ButtonAddBench;
		private System.Windows.Forms.TreeView treeView1;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			CLIENTE = new Label();
			NomeCliente = new Label();
			RagioneFiscaleCliente = new Label();
			TagCliente = new Label();
			textBoxNomeCliente = new TextBox();
			textBoxRagioneFiscaleCliente = new TextBox();
			textBoxTagCliente = new TextBox();
			PLANT = new Label();
			NomePlant = new Label();
			NazionePlant = new Label();
			CittaPlant = new Label();
			IndirizzoPlant = new Label();
			TagPlant = new Label();
			textBoxNomePlant = new TextBox();
			textBoxNazionePlant = new TextBox();
			textBoxCittaPlant = new TextBox();
			textBoxIndirizzoPlant = new TextBox();
			textBoxTagPlant = new TextBox();
			BANCO = new Label();
			NomeBanco = new Label();
			urlGitBanco = new Label();
			tagBanco = new Label();
			textBoxNomeBanco = new TextBox();
			textBoxUrlGitBanco = new TextBox();
			textBoxTagBanco = new TextBox();
			ButtonAggiungiCliente = new Button();
			ButtonAggiungiPlant = new Button();
			ButtonAddBench = new Button();
			treeView1 = new TreeView();
			ButtonModificaCliente = new Button();
			ButtonGestisciPlant = new Button();
			ButtonGestisciBanco = new Button();
			ButtonDeleteClient = new Button();
			ButtonDeletePlant = new Button();
			ButtonDeleteBanco = new Button();
			ButtonTextBoxesClient = new Button();
			ButtonTextBoxesPlant = new Button();
			ButtonTextBoxesBanco = new Button();
			SuspendLayout();
			// 
			// CLIENTE
			// 
			CLIENTE.AutoSize = true;
			CLIENTE.Font = new Font("Segoe UI", 15F);
			CLIENTE.Location = new Point(129, 28);
			CLIENTE.Name = "CLIENTE";
			CLIENTE.Size = new Size(107, 35);
			CLIENTE.TabIndex = 0;
			CLIENTE.Text = "CLIENTE";
			// 
			// NomeCliente
			// 
			NomeCliente.AutoSize = true;
			NomeCliente.Location = new Point(77, 125);
			NomeCliente.Name = "NomeCliente";
			NomeCliente.Size = new Size(50, 20);
			NomeCliente.TabIndex = 2;
			NomeCliente.Text = "Nome";
			// 
			// RagioneFiscaleCliente
			// 
			RagioneFiscaleCliente.AutoSize = true;
			RagioneFiscaleCliente.Location = new Point(15, 168);
			RagioneFiscaleCliente.Name = "RagioneFiscaleCliente";
			RagioneFiscaleCliente.Size = new Size(112, 20);
			RagioneFiscaleCliente.TabIndex = 3;
			RagioneFiscaleCliente.Text = "Ragione Fiscale";
			// 
			// TagCliente
			// 
			TagCliente.AutoSize = true;
			TagCliente.Location = new Point(95, 207);
			TagCliente.Name = "TagCliente";
			TagCliente.Size = new Size(32, 20);
			TagCliente.TabIndex = 4;
			TagCliente.Text = "Tag";
			// 
			// textBoxNomeCliente
			// 
			textBoxNomeCliente.Location = new Point(133, 122);
			textBoxNomeCliente.Name = "textBoxNomeCliente";
			textBoxNomeCliente.Size = new Size(125, 27);
			textBoxNomeCliente.TabIndex = 6;
			// 
			// textBoxRagioneFiscaleCliente
			// 
			textBoxRagioneFiscaleCliente.Location = new Point(133, 161);
			textBoxRagioneFiscaleCliente.Name = "textBoxRagioneFiscaleCliente";
			textBoxRagioneFiscaleCliente.Size = new Size(125, 27);
			textBoxRagioneFiscaleCliente.TabIndex = 7;
			// 
			// textBoxTagCliente
			// 
			textBoxTagCliente.Location = new Point(133, 204);
			textBoxTagCliente.Name = "textBoxTagCliente";
			textBoxTagCliente.Size = new Size(125, 27);
			textBoxTagCliente.TabIndex = 8;
			// 
			// PLANT
			// 
			PLANT.AutoSize = true;
			PLANT.Font = new Font("Segoe UI", 15F);
			PLANT.Location = new Point(460, 28);
			PLANT.Name = "PLANT";
			PLANT.Size = new Size(90, 35);
			PLANT.TabIndex = 9;
			PLANT.Text = "PLANT";
			// 
			// NomePlant
			// 
			NomePlant.AutoSize = true;
			NomePlant.Location = new Point(413, 125);
			NomePlant.Name = "NomePlant";
			NomePlant.Size = new Size(50, 20);
			NomePlant.TabIndex = 12;
			NomePlant.Text = "Nome";
			// 
			// NazionePlant
			// 
			NazionePlant.AutoSize = true;
			NazionePlant.Location = new Point(399, 168);
			NazionePlant.Name = "NazionePlant";
			NazionePlant.Size = new Size(64, 20);
			NazionePlant.TabIndex = 13;
			NazionePlant.Text = "Nazione";
			// 
			// CittaPlant
			// 
			CittaPlant.AutoSize = true;
			CittaPlant.Location = new Point(423, 207);
			CittaPlant.Name = "CittaPlant";
			CittaPlant.Size = new Size(40, 20);
			CittaPlant.TabIndex = 14;
			CittaPlant.Text = "Città";
			// 
			// IndirizzoPlant
			// 
			IndirizzoPlant.AutoSize = true;
			IndirizzoPlant.Location = new Point(397, 247);
			IndirizzoPlant.Name = "IndirizzoPlant";
			IndirizzoPlant.Size = new Size(66, 20);
			IndirizzoPlant.TabIndex = 15;
			IndirizzoPlant.Text = "Indirizzo";
			// 
			// TagPlant
			// 
			TagPlant.AutoSize = true;
			TagPlant.Location = new Point(431, 288);
			TagPlant.Name = "TagPlant";
			TagPlant.Size = new Size(32, 20);
			TagPlant.TabIndex = 16;
			TagPlant.Text = "Tag";
			// 
			// textBoxNomePlant
			// 
			textBoxNomePlant.Location = new Point(469, 122);
			textBoxNomePlant.Name = "textBoxNomePlant";
			textBoxNomePlant.Size = new Size(125, 27);
			textBoxNomePlant.TabIndex = 19;
			// 
			// textBoxNazionePlant
			// 
			textBoxNazionePlant.Location = new Point(469, 165);
			textBoxNazionePlant.Name = "textBoxNazionePlant";
			textBoxNazionePlant.Size = new Size(125, 27);
			textBoxNazionePlant.TabIndex = 20;
			// 
			// textBoxCittaPlant
			// 
			textBoxCittaPlant.Location = new Point(469, 205);
			textBoxCittaPlant.Name = "textBoxCittaPlant";
			textBoxCittaPlant.Size = new Size(125, 27);
			textBoxCittaPlant.TabIndex = 21;
			// 
			// textBoxIndirizzoPlant
			// 
			textBoxIndirizzoPlant.Location = new Point(469, 244);
			textBoxIndirizzoPlant.Name = "textBoxIndirizzoPlant";
			textBoxIndirizzoPlant.Size = new Size(125, 27);
			textBoxIndirizzoPlant.TabIndex = 22;
			// 
			// textBoxTagPlant
			// 
			textBoxTagPlant.Location = new Point(469, 285);
			textBoxTagPlant.Name = "textBoxTagPlant";
			textBoxTagPlant.Size = new Size(125, 27);
			textBoxTagPlant.TabIndex = 23;
			// 
			// BANCO
			// 
			BANCO.AutoSize = true;
			BANCO.Font = new Font("Segoe UI", 15F);
			BANCO.Location = new Point(817, 28);
			BANCO.Name = "BANCO";
			BANCO.Size = new Size(97, 35);
			BANCO.TabIndex = 24;
			BANCO.Text = "BANCO";
			// 
			// NomeBanco
			// 
			NomeBanco.AutoSize = true;
			NomeBanco.Location = new Point(762, 125);
			NomeBanco.Name = "NomeBanco";
			NomeBanco.Size = new Size(50, 20);
			NomeBanco.TabIndex = 26;
			NomeBanco.Text = "Nome";
			// 
			// urlGitBanco
			// 
			urlGitBanco.AutoSize = true;
			urlGitBanco.Location = new Point(763, 168);
			urlGitBanco.Name = "urlGitBanco";
			urlGitBanco.Size = new Size(49, 20);
			urlGitBanco.TabIndex = 27;
			urlGitBanco.Text = "url Git";
			// 
			// tagBanco
			// 
			tagBanco.AutoSize = true;
			tagBanco.Location = new Point(780, 207);
			tagBanco.Name = "tagBanco";
			tagBanco.Size = new Size(32, 20);
			tagBanco.TabIndex = 28;
			tagBanco.Text = "Tag";
			// 
			// textBoxNomeBanco
			// 
			textBoxNomeBanco.Location = new Point(817, 122);
			textBoxNomeBanco.Name = "textBoxNomeBanco";
			textBoxNomeBanco.Size = new Size(125, 27);
			textBoxNomeBanco.TabIndex = 32;
			// 
			// textBoxUrlGitBanco
			// 
			textBoxUrlGitBanco.Location = new Point(817, 165);
			textBoxUrlGitBanco.Name = "textBoxUrlGitBanco";
			textBoxUrlGitBanco.Size = new Size(125, 27);
			textBoxUrlGitBanco.TabIndex = 33;
			// 
			// textBoxTagBanco
			// 
			textBoxTagBanco.Location = new Point(817, 205);
			textBoxTagBanco.Name = "textBoxTagBanco";
			textBoxTagBanco.Size = new Size(125, 27);
			textBoxTagBanco.TabIndex = 34;
			// 
			// ButtonAggiungiCliente
			// 
			ButtonAggiungiCliente.Font = new Font("Segoe UI", 15F);
			ButtonAggiungiCliente.Location = new Point(15, 257);
			ButtonAggiungiCliente.Name = "ButtonAggiungiCliente";
			ButtonAggiungiCliente.Size = new Size(243, 55);
			ButtonAggiungiCliente.TabIndex = 35;
			ButtonAggiungiCliente.Text = "AGGIUNGI CLIENTE";
			ButtonAggiungiCliente.UseVisualStyleBackColor = true;
			ButtonAggiungiCliente.Click += ButtonAddClient_Click;
			// 
			// ButtonAggiungiPlant
			// 
			ButtonAggiungiPlant.Font = new Font("Segoe UI", 15F);
			ButtonAggiungiPlant.Location = new Point(369, 344);
			ButtonAggiungiPlant.Name = "ButtonAggiungiPlant";
			ButtonAggiungiPlant.Size = new Size(225, 55);
			ButtonAggiungiPlant.TabIndex = 36;
			ButtonAggiungiPlant.Text = "AGGIUNGI PLANT";
			ButtonAggiungiPlant.UseVisualStyleBackColor = true;
			ButtonAggiungiPlant.Click += ButtonAddPlant_Click;
			// 
			// ButtonAddBench
			// 
			ButtonAddBench.Font = new Font("Segoe UI", 15F);
			ButtonAddBench.Location = new Point(695, 264);
			ButtonAddBench.Name = "ButtonAddBench";
			ButtonAddBench.Size = new Size(247, 55);
			ButtonAddBench.TabIndex = 37;
			ButtonAddBench.Text = "AGGIUNGI BANCO";
			ButtonAddBench.UseVisualStyleBackColor = true;
			ButtonAddBench.Click += ButtonAddBench_Click;
			// 
			// treeView1
			// 
			treeView1.Location = new Point(16, 595);
			treeView1.Name = "treeView1";
			treeView1.Size = new Size(931, 196);
			treeView1.TabIndex = 38;
			// 
			// ButtonModificaCliente
			// 
			ButtonModificaCliente.Font = new Font("Segoe UI", 15F);
			ButtonModificaCliente.Location = new Point(15, 328);
			ButtonModificaCliente.Name = "ButtonModificaCliente";
			ButtonModificaCliente.Size = new Size(243, 51);
			ButtonModificaCliente.TabIndex = 39;
			ButtonModificaCliente.Text = "MODIFICA CLIENTE";
			ButtonModificaCliente.UseVisualStyleBackColor = true;
			ButtonModificaCliente.Click += ButtonModificaCliente_Click;
			// 
			// ButtonGestisciPlant
			// 
			ButtonGestisciPlant.Font = new Font("Segoe UI", 15F);
			ButtonGestisciPlant.Location = new Point(369, 415);
			ButtonGestisciPlant.Name = "ButtonGestisciPlant";
			ButtonGestisciPlant.Size = new Size(225, 59);
			ButtonGestisciPlant.TabIndex = 40;
			ButtonGestisciPlant.Text = "MODIFICA PLANT";
			ButtonGestisciPlant.UseVisualStyleBackColor = true;
			ButtonGestisciPlant.Click += ButtonGestisciPlant_Click;
			// 
			// ButtonGestisciBanco
			// 
			ButtonGestisciBanco.Font = new Font("Segoe UI", 15F);
			ButtonGestisciBanco.Location = new Point(695, 329);
			ButtonGestisciBanco.Name = "ButtonGestisciBanco";
			ButtonGestisciBanco.Size = new Size(247, 55);
			ButtonGestisciBanco.TabIndex = 41;
			ButtonGestisciBanco.Text = "MODIFICA BANCO";
			ButtonGestisciBanco.UseVisualStyleBackColor = true;
			ButtonGestisciBanco.Click += ButtonGestisciBanco_Click;
			// 
			// ButtonDeleteClient
			// 
			ButtonDeleteClient.Font = new Font("Segoe UI", 15F);
			ButtonDeleteClient.Location = new Point(15, 395);
			ButtonDeleteClient.Name = "ButtonDeleteClient";
			ButtonDeleteClient.Size = new Size(242, 51);
			ButtonDeleteClient.TabIndex = 42;
			ButtonDeleteClient.Text = "ELIMINA CLIENTE";
			ButtonDeleteClient.UseVisualStyleBackColor = true;
			ButtonDeleteClient.Click += ButtonDeleteClient_Click;
			// 
			// ButtonDeletePlant
			// 
			ButtonDeletePlant.Font = new Font("Segoe UI", 15F);
			ButtonDeletePlant.Location = new Point(369, 492);
			ButtonDeletePlant.Name = "ButtonDeletePlant";
			ButtonDeletePlant.Size = new Size(225, 59);
			ButtonDeletePlant.TabIndex = 43;
			ButtonDeletePlant.Text = "ELIMINA PLANT";
			ButtonDeletePlant.UseVisualStyleBackColor = true;
			ButtonDeletePlant.Click += ButtonDeletePlant_Click;
			// 
			// ButtonDeleteBanco
			// 
			ButtonDeleteBanco.Font = new Font("Segoe UI", 15F);
			ButtonDeleteBanco.Location = new Point(695, 396);
			ButtonDeleteBanco.Name = "ButtonDeleteBanco";
			ButtonDeleteBanco.Size = new Size(247, 55);
			ButtonDeleteBanco.TabIndex = 44;
			ButtonDeleteBanco.Text = "ELIMINA BANCO";
			ButtonDeleteBanco.UseVisualStyleBackColor = true;
			ButtonDeleteBanco.Click += ButtonDeleteBanco_Click;
			// 
			// ButtonTextBoxesClient
			// 
			ButtonTextBoxesClient.Location = new Point(95, 63);
			ButtonTextBoxesClient.Name = "ButtonTextBoxesClient";
			ButtonTextBoxesClient.Size = new Size(162, 50);
			ButtonTextBoxesClient.TabIndex = 45;
			ButtonTextBoxesClient.Text = "Aggiungi un nuovo cliente";
			ButtonTextBoxesClient.UseVisualStyleBackColor = true;
			ButtonTextBoxesClient.Click += ButtonTextBoxesClient_Click;
			// 
			// ButtonTextBoxesPlant
			// 
			ButtonTextBoxesPlant.Location = new Point(432, 63);
			ButtonTextBoxesPlant.Name = "ButtonTextBoxesPlant";
			ButtonTextBoxesPlant.Size = new Size(162, 50);
			ButtonTextBoxesPlant.TabIndex = 46;
			ButtonTextBoxesPlant.Text = "Aggiungi un nuovo plant";
			ButtonTextBoxesPlant.UseVisualStyleBackColor = true;
			ButtonTextBoxesPlant.Click += ButtonTextBoxesPlant_Click;
			// 
			// ButtonTextBoxesBanco
			// 
			ButtonTextBoxesBanco.Location = new Point(785, 60);
			ButtonTextBoxesBanco.Name = "ButtonTextBoxesBanco";
			ButtonTextBoxesBanco.Size = new Size(162, 53);
			ButtonTextBoxesBanco.TabIndex = 47;
			ButtonTextBoxesBanco.Text = "Aggiungi un nuovo banco";
			ButtonTextBoxesBanco.UseVisualStyleBackColor = true;
			ButtonTextBoxesBanco.Click += ButtonTextBoxesBanco_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(959, 803);
			Controls.Add(ButtonTextBoxesBanco);
			Controls.Add(ButtonTextBoxesPlant);
			Controls.Add(ButtonTextBoxesClient);
			Controls.Add(ButtonDeleteBanco);
			Controls.Add(ButtonDeletePlant);
			Controls.Add(ButtonDeleteClient);
			Controls.Add(ButtonGestisciBanco);
			Controls.Add(ButtonGestisciPlant);
			Controls.Add(ButtonModificaCliente);
			Controls.Add(treeView1);
			Controls.Add(ButtonAddBench);
			Controls.Add(ButtonAggiungiPlant);
			Controls.Add(ButtonAggiungiCliente);
			Controls.Add(textBoxTagBanco);
			Controls.Add(textBoxUrlGitBanco);
			Controls.Add(textBoxNomeBanco);
			Controls.Add(tagBanco);
			Controls.Add(urlGitBanco);
			Controls.Add(NomeBanco);
			Controls.Add(BANCO);
			Controls.Add(textBoxTagPlant);
			Controls.Add(textBoxIndirizzoPlant);
			Controls.Add(textBoxCittaPlant);
			Controls.Add(textBoxNazionePlant);
			Controls.Add(textBoxNomePlant);
			Controls.Add(TagPlant);
			Controls.Add(IndirizzoPlant);
			Controls.Add(CittaPlant);
			Controls.Add(NazionePlant);
			Controls.Add(NomePlant);
			Controls.Add(PLANT);
			Controls.Add(textBoxTagCliente);
			Controls.Add(textBoxRagioneFiscaleCliente);
			Controls.Add(textBoxNomeCliente);
			Controls.Add(TagCliente);
			Controls.Add(RagioneFiscaleCliente);
			Controls.Add(NomeCliente);
			Controls.Add(CLIENTE);
			Name = "Form1";
			Text = "FormCreazione";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button ButtonModificaCliente;
		private Button ButtonGestisciPlant;
		private Button ButtonGestisciBanco;
		private Button ButtonDeleteClient;
		private Button ButtonDeletePlant;
		private Button ButtonDeleteBanco;
		private Button ButtonTextBoxesClient;
		private Button ButtonTextBoxesPlant;
		private Button ButtonTextBoxesBanco;
	}
}