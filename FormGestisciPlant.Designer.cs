namespace Prova
{
	partial class FormGestisciPlant
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
			listViewGestisciPlant = new ListView();
			ButtonModificaPlant = new Button();
			ButtonDeletePlant = new Button();
			SuspendLayout();
			// 
			// listViewGestisciPlant
			// 
			listViewGestisciPlant.Location = new Point(12, 12);
			listViewGestisciPlant.Name = "listViewGestisciPlant";
			listViewGestisciPlant.Size = new Size(661, 428);
			listViewGestisciPlant.TabIndex = 0;
			listViewGestisciPlant.UseCompatibleStateImageBehavior = false;
			// 
			// ButtonModificaPlant
			// 
			ButtonModificaPlant.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			ButtonModificaPlant.Location = new Point(711, 12);
			ButtonModificaPlant.Name = "ButtonModificaPlant";
			ButtonModificaPlant.Size = new Size(229, 125);
			ButtonModificaPlant.TabIndex = 1;
			ButtonModificaPlant.Text = "MODIFICA PLANT";
			ButtonModificaPlant.UseVisualStyleBackColor = true;
			ButtonModificaPlant.Click += ButtonModificaPlant_Click;
			// 
			// ButtonDeletePlant
			// 
			ButtonDeletePlant.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			ButtonDeletePlant.Location = new Point(711, 315);
			ButtonDeletePlant.Name = "ButtonDeletePlant";
			ButtonDeletePlant.Size = new Size(229, 125);
			ButtonDeletePlant.TabIndex = 2;
			ButtonDeletePlant.Text = "ELIMINA PLANT";
			ButtonDeletePlant.UseVisualStyleBackColor = true;
			ButtonDeletePlant.Click += ButtonDeletePlant_Click;
			// 
			// FormGestisciPlant
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(952, 452);
			Controls.Add(ButtonDeletePlant);
			Controls.Add(ButtonModificaPlant);
			Controls.Add(listViewGestisciPlant);
			Name = "FormGestisciPlant";
			Text = "FormGestisciPlant";
			ResumeLayout(false);
		}

		#endregion

		private ListView listViewGestisciPlant;
		private Button ButtonModificaPlant;
		private Button ButtonDeletePlant;
	}
}