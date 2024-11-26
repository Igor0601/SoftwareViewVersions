namespace Loccioni.SoftwareViewVersions.WinForms
{
	partial class FormSelezionaPlant
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
			listViewPlants = new ListView();
			ButtonSelezionaPlant = new Button();
			SuspendLayout();
			// 
			// listViewPlants
			// 
			listViewPlants.Location = new Point(12, 12);
			listViewPlants.Name = "listViewPlants";
			listViewPlants.Size = new Size(490, 426);
			listViewPlants.TabIndex = 0;
			listViewPlants.UseCompatibleStateImageBehavior = false;
			// 
			// ButtonSelezionaPlant
			// 
			ButtonSelezionaPlant.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			ButtonSelezionaPlant.Location = new Point(565, 123);
			ButtonSelezionaPlant.Name = "ButtonSelezionaPlant";
			ButtonSelezionaPlant.Size = new Size(223, 112);
			ButtonSelezionaPlant.TabIndex = 1;
			ButtonSelezionaPlant.Text = "SELEZIONA PLANT";
			ButtonSelezionaPlant.UseVisualStyleBackColor = true;
			ButtonSelezionaPlant.Click += ButtonSelezionaPlant_Click;
			// 
			// FormGestisciPlant
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(ButtonSelezionaPlant);
			Controls.Add(listViewPlants);
			Name = "FormGestisciPlant";
			Text = "FormGestisciPlant";
			ResumeLayout(false);
		}

		#endregion

		private ListView listViewPlants;
		private Button ButtonSelezionaPlant;
	}
}