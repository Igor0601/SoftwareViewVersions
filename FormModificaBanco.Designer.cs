namespace Prova
{
	partial class FormModificaBanco
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
			textBoxNomeBancoModificato = new TextBox();
			textBoxUrlGitBancoModificato = new TextBox();
			textBoxTagBancoModificato = new TextBox();
			ButtonModificaBanco = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(414, 46);
			label1.TabIndex = 0;
			label1.Text = "COSA VUOI MODIFICARE?";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(38, 69);
			label2.Name = "label2";
			label2.Size = new Size(50, 20);
			label2.TabIndex = 1;
			label2.Text = "Nome";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(41, 111);
			label3.Name = "label3";
			label3.Size = new Size(47, 20);
			label3.TabIndex = 2;
			label3.Text = "UrlGit";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(56, 150);
			label4.Name = "label4";
			label4.Size = new Size(32, 20);
			label4.TabIndex = 3;
			label4.Text = "Tag";
			// 
			// textBoxNomeBancoModificato
			// 
			textBoxNomeBancoModificato.Location = new Point(94, 66);
			textBoxNomeBancoModificato.Name = "textBoxNomeBancoModificato";
			textBoxNomeBancoModificato.Size = new Size(125, 27);
			textBoxNomeBancoModificato.TabIndex = 4;
			// 
			// textBoxUrlGitBancoModificato
			// 
			textBoxUrlGitBancoModificato.Location = new Point(94, 108);
			textBoxUrlGitBancoModificato.Name = "textBoxUrlGitBancoModificato";
			textBoxUrlGitBancoModificato.Size = new Size(125, 27);
			textBoxUrlGitBancoModificato.TabIndex = 5;
			// 
			// textBoxTagBancoModificato
			// 
			textBoxTagBancoModificato.Location = new Point(94, 150);
			textBoxTagBancoModificato.Name = "textBoxTagBancoModificato";
			textBoxTagBancoModificato.Size = new Size(125, 27);
			textBoxTagBancoModificato.TabIndex = 6;
			// 
			// ButtonModificaBanco
			// 
			ButtonModificaBanco.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			ButtonModificaBanco.Location = new Point(243, 66);
			ButtonModificaBanco.Name = "ButtonModificaBanco";
			ButtonModificaBanco.Size = new Size(183, 111);
			ButtonModificaBanco.TabIndex = 7;
			ButtonModificaBanco.Text = "MODIFICA";
			ButtonModificaBanco.UseVisualStyleBackColor = true;
			ButtonModificaBanco.Click += ButtonModificaBanco_Click;
			// 
			// FormModificaBanco
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(480, 221);
			Controls.Add(ButtonModificaBanco);
			Controls.Add(textBoxTagBancoModificato);
			Controls.Add(textBoxUrlGitBancoModificato);
			Controls.Add(textBoxNomeBancoModificato);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FormModificaBanco";
			Text = "FormModificaBanco";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox textBoxNomeBancoModificato;
		private TextBox textBoxUrlGitBancoModificato;
		private TextBox textBoxTagBancoModificato;
		private Button ButtonModificaBanco;
	}
}