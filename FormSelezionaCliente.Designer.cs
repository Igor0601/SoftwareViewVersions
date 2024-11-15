namespace Prova
{
	partial class FormSelezionaCliente
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListView listViewClienti;
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			listViewClienti = new ListView();
			buttonIdCliente = new Button();
			SuspendLayout();
			// 
			// listViewClienti
			// 
			listViewClienti.Location = new Point(12, 12);
			listViewClienti.Name = "listViewClienti";
			listViewClienti.Size = new Size(468, 412);
			listViewClienti.TabIndex = 1;
			listViewClienti.UseCompatibleStateImageBehavior = false;
			// 
			// buttonIdCliente
			// 
			buttonIdCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			buttonIdCliente.Location = new Point(565, 12);
			buttonIdCliente.Name = "buttonIdCliente";
			buttonIdCliente.Size = new Size(223, 124);
			buttonIdCliente.TabIndex = 2;
			buttonIdCliente.Text = "SELEZIONA CLIENTE";
			buttonIdCliente.UseVisualStyleBackColor = true;
			buttonIdCliente.Click += ButtonIdCliente_Click;
			// 
			// FormGestisciCliente
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(buttonIdCliente);
			Controls.Add(listViewClienti);
			Name = "FormGestisciCliente";
			Text = "FormGestisciCliente";
			ResumeLayout(false);
		}

		private Button buttonIdCliente;
	}
}