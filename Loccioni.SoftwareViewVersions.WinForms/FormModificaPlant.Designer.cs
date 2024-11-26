namespace Loccioni.SoftwareViewVersions.WinForms
{
	partial class FormModificaPlant
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			textBoxNomePlantModificato = new TextBox();
			textBoxNazionePlantModificato = new TextBox();
			textBoxCittaPlantModificato = new TextBox();
			textBoxIndirizzoPlantModificato = new TextBox();
			textBoxTagPlantModificato = new TextBox();
			ButtonModificaPlant = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(513, 57);
			label1.TabIndex = 0;
			label1.Text = "COSA VUOI MODIFICARE?\r\n";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(43, 102);
			label2.Name = "label2";
			label2.Size = new Size(52, 20);
			label2.TabIndex = 1;
			label2.Text = "NOME";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(22, 144);
			label3.Name = "label3";
			label3.Size = new Size(73, 20);
			label3.TabIndex = 2;
			label3.Text = "NAZIONE";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(43, 178);
			label4.Name = "label4";
			label4.Size = new Size(50, 20);
			label4.TabIndex = 3;
			label4.Text = "CITTA'";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 217);
			label5.Name = "label5";
			label5.Size = new Size(81, 20);
			label5.TabIndex = 4;
			label5.Text = "INDIRIZZO";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(57, 258);
			label6.Name = "label6";
			label6.Size = new Size(36, 20);
			label6.TabIndex = 5;
			label6.Text = "TAG";
			// 
			// textBoxNomePlantModificato
			// 
			textBoxNomePlantModificato.Location = new Point(121, 100);
			textBoxNomePlantModificato.Name = "textBoxNomePlantModificato";
			textBoxNomePlantModificato.Size = new Size(125, 27);
			textBoxNomePlantModificato.TabIndex = 6;
			// 
			// textBoxNazionePlantModificato
			// 
			textBoxNazionePlantModificato.Location = new Point(121, 141);
			textBoxNazionePlantModificato.Name = "textBoxNazionePlantModificato";
			textBoxNazionePlantModificato.Size = new Size(125, 27);
			textBoxNazionePlantModificato.TabIndex = 7;
			// 
			// textBoxCittaPlantModificato
			// 
			textBoxCittaPlantModificato.Location = new Point(121, 175);
			textBoxCittaPlantModificato.Name = "textBoxCittaPlantModificato";
			textBoxCittaPlantModificato.Size = new Size(125, 27);
			textBoxCittaPlantModificato.TabIndex = 8;
			// 
			// textBoxIndirizzoPlantModificato
			// 
			textBoxIndirizzoPlantModificato.Location = new Point(121, 214);
			textBoxIndirizzoPlantModificato.Name = "textBoxIndirizzoPlantModificato";
			textBoxIndirizzoPlantModificato.Size = new Size(125, 27);
			textBoxIndirizzoPlantModificato.TabIndex = 9;
			// 
			// textBoxTagPlantModificato
			// 
			textBoxTagPlantModificato.Location = new Point(121, 255);
			textBoxTagPlantModificato.Name = "textBoxTagPlantModificato";
			textBoxTagPlantModificato.Size = new Size(125, 27);
			textBoxTagPlantModificato.TabIndex = 10;
			// 
			// ButtonModificaPlant
			// 
			ButtonModificaPlant.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			ButtonModificaPlant.Location = new Point(279, 91);
			ButtonModificaPlant.Name = "ButtonModificaPlant";
			ButtonModificaPlant.Size = new Size(246, 184);
			ButtonModificaPlant.TabIndex = 11;
			ButtonModificaPlant.Text = "MODIFICA PLANT";
			ButtonModificaPlant.UseVisualStyleBackColor = true;
			ButtonModificaPlant.Click += ButtonModificaPlant_Click;
			// 
			// FormModificaPlant
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(547, 299);
			Controls.Add(ButtonModificaPlant);
			Controls.Add(textBoxTagPlantModificato);
			Controls.Add(textBoxIndirizzoPlantModificato);
			Controls.Add(textBoxCittaPlantModificato);
			Controls.Add(textBoxNazionePlantModificato);
			Controls.Add(textBoxNomePlantModificato);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FormModificaPlant";
			Text = "FormModificaPlant";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox textBoxNomePlantModificato;
		private TextBox textBoxNazionePlantModificato;
		private TextBox textBoxCittaPlantModificato;
		private TextBox textBoxIndirizzoPlantModificato;
		private TextBox textBoxTagPlantModificato;
		private Button ButtonModificaPlant;
	}
}