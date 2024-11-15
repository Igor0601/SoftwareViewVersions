namespace Prova
{
	partial class FormGestisciBanco
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
			listViewGestisciBanco = new ListView();
			ButtonModificaBanco = new Button();
			ButtonEliminaBanco = new Button();
			SuspendLayout();
			// 
			// listViewGestisciBanco
			// 
			listViewGestisciBanco.Location = new Point(12, 12);
			listViewGestisciBanco.Name = "listViewGestisciBanco";
			listViewGestisciBanco.Size = new Size(494, 426);
			listViewGestisciBanco.TabIndex = 0;
			listViewGestisciBanco.UseCompatibleStateImageBehavior = false;
			// 
			// ButtonModificaBanco
			// 
			ButtonModificaBanco.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			ButtonModificaBanco.Location = new Point(565, 12);
			ButtonModificaBanco.Name = "ButtonModificaBanco";
			ButtonModificaBanco.Size = new Size(223, 129);
			ButtonModificaBanco.TabIndex = 1;
			ButtonModificaBanco.Text = "MODIFICA BANCO";
			ButtonModificaBanco.UseVisualStyleBackColor = true;
			ButtonModificaBanco.Click += ButtonModificaBanco_Click;
			// 
			// ButtonEliminaBanco
			// 
			ButtonEliminaBanco.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			ButtonEliminaBanco.Location = new Point(565, 309);
			ButtonEliminaBanco.Name = "ButtonEliminaBanco";
			ButtonEliminaBanco.Size = new Size(223, 129);
			ButtonEliminaBanco.TabIndex = 2;
			ButtonEliminaBanco.Text = "ELIMINA BANCO";
			ButtonEliminaBanco.UseVisualStyleBackColor = true;
			ButtonEliminaBanco.Click += ButtonEliminaBanco_Click;
			// 
			// FormGestisciBanco
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(ButtonEliminaBanco);
			Controls.Add(ButtonModificaBanco);
			Controls.Add(listViewGestisciBanco);
			Name = "FormGestisciBanco";
			Text = "FormGestisciBanco";
			ResumeLayout(false);
		}

		#endregion

		private ListView listViewGestisciBanco;
		private Button ButtonModificaBanco;
		private Button ButtonEliminaBanco;
	}
}