namespace Prova
{
	partial class FormGestisciCliente
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
			listViewGestisciCliente = new ListView();
			ButtonModificaCliente = new Button();
			ButtonEliminaCliente = new Button();
			SuspendLayout();
			// 
			// listViewGestisciCliente
			// 
			listViewGestisciCliente.Location = new Point(12, 12);
			listViewGestisciCliente.Name = "listViewGestisciCliente";
			listViewGestisciCliente.Size = new Size(507, 426);
			listViewGestisciCliente.TabIndex = 0;
			listViewGestisciCliente.UseCompatibleStateImageBehavior = false;
			// 
			// ButtonModificaCliente
			// 
			ButtonModificaCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			ButtonModificaCliente.Location = new Point(564, 12);
			ButtonModificaCliente.Name = "ButtonModificaCliente";
			ButtonModificaCliente.Size = new Size(224, 139);
			ButtonModificaCliente.TabIndex = 1;
			ButtonModificaCliente.Text = "MODIFICA CLIENTE";
			ButtonModificaCliente.UseVisualStyleBackColor = true;
			ButtonModificaCliente.Click += ButtonModificaCliente_Click;
			// 
			// ButtonEliminaCliente
			// 
			ButtonEliminaCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			ButtonEliminaCliente.Location = new Point(564, 299);
			ButtonEliminaCliente.Name = "ButtonEliminaCliente";
			ButtonEliminaCliente.Size = new Size(224, 139);
			ButtonEliminaCliente.TabIndex = 2;
			ButtonEliminaCliente.Text = "ELIMINA CLIENTE";
			ButtonEliminaCliente.UseVisualStyleBackColor = true;
			ButtonEliminaCliente.Click += ButtonEliminaCliente_Click;
			// 
			// FormGestisciCliente
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(ButtonEliminaCliente);
			Controls.Add(ButtonModificaCliente);
			Controls.Add(listViewGestisciCliente);
			Name = "FormGestisciCliente";
			Text = "FormGestisciCliente";
			ResumeLayout(false);
		}

		#endregion

		private ListView listViewGestisciCliente;
		private Button ButtonModificaCliente;
		private Button ButtonEliminaCliente;
	}
}