namespace Loccioni.SoftwareViewVersions.WinForms
{
	partial class FormModificaCliente
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
			textBoxNomeClienteModifica = new TextBox();
			textBoxRagioneFiscaleClienteModifica = new TextBox();
			textBoxTagClienteModifica = new TextBox();
			ButtonModificaCliente = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(571, 67);
			label1.TabIndex = 0;
			label1.Text = "COSA VUOI MODICARE?";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(105, 148);
			label2.Name = "label2";
			label2.Size = new Size(50, 20);
			label2.TabIndex = 1;
			label2.Text = "Nome";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(45, 191);
			label3.Name = "label3";
			label3.Size = new Size(110, 20);
			label3.TabIndex = 2;
			label3.Text = "Ragione fiscale";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(123, 229);
			label4.Name = "label4";
			label4.Size = new Size(32, 20);
			label4.TabIndex = 3;
			label4.Text = "Tag";
			// 
			// textBoxNomeClienteModifica
			// 
			textBoxNomeClienteModifica.Location = new Point(161, 145);
			textBoxNomeClienteModifica.Name = "textBoxNomeClienteModifica";
			textBoxNomeClienteModifica.Size = new Size(125, 27);
			textBoxNomeClienteModifica.TabIndex = 4;
			// 
			// textBoxRagioneFiscaleClienteModifica
			// 
			textBoxRagioneFiscaleClienteModifica.Location = new Point(161, 188);
			textBoxRagioneFiscaleClienteModifica.Name = "textBoxRagioneFiscaleClienteModifica";
			textBoxRagioneFiscaleClienteModifica.Size = new Size(125, 27);
			textBoxRagioneFiscaleClienteModifica.TabIndex = 5;
			// 
			// textBoxTagClienteModifica
			// 
			textBoxTagClienteModifica.Location = new Point(161, 226);
			textBoxTagClienteModifica.Name = "textBoxTagClienteModifica";
			textBoxTagClienteModifica.Size = new Size(125, 27);
			textBoxTagClienteModifica.TabIndex = 6;
			// 
			// ButtonModificaCliente
			// 
			ButtonModificaCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			ButtonModificaCliente.Location = new Point(388, 139);
			ButtonModificaCliente.Name = "ButtonModificaCliente";
			ButtonModificaCliente.Size = new Size(205, 114);
			ButtonModificaCliente.TabIndex = 7;
			ButtonModificaCliente.Text = "MODIFICA";
			ButtonModificaCliente.UseVisualStyleBackColor = true;
			ButtonModificaCliente.Click += ButtonModificaCliente_Click;
			// 
			// FormModificaCliente
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(624, 285);
			Controls.Add(ButtonModificaCliente);
			Controls.Add(textBoxTagClienteModifica);
			Controls.Add(textBoxRagioneFiscaleClienteModifica);
			Controls.Add(textBoxNomeClienteModifica);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FormModificaCliente";
			Text = "FormModificaCliente";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox textBoxNomeClienteModifica;
		private TextBox textBoxRagioneFiscaleClienteModifica;
		private TextBox textBoxTagClienteModifica;
		private Button ButtonModificaCliente;
	}
}