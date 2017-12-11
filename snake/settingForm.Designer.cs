namespace snake
{
	partial class settingForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxMapSize = new System.Windows.Forms.ComboBox();
			this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Map Size:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "Difficulty:";
			// 
			// comboBoxMapSize
			// 
			this.comboBoxMapSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMapSize.FormattingEnabled = true;
			this.comboBoxMapSize.Location = new System.Drawing.Point(106, 22);
			this.comboBoxMapSize.Name = "comboBoxMapSize";
			this.comboBoxMapSize.Size = new System.Drawing.Size(121, 20);
			this.comboBoxMapSize.TabIndex = 2;
			// 
			// comboBoxDifficulty
			// 
			this.comboBoxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDifficulty.FormattingEnabled = true;
			this.comboBoxDifficulty.Location = new System.Drawing.Point(106, 51);
			this.comboBoxDifficulty.Name = "comboBoxDifficulty";
			this.comboBoxDifficulty.Size = new System.Drawing.Size(121, 20);
			this.comboBoxDifficulty.TabIndex = 3;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(152, 88);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// settingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(244, 126);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.comboBoxDifficulty);
			this.Controls.Add(this.comboBoxMapSize);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "settingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Setting";
			this.Load += new System.EventHandler(this.settingForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxMapSize;
		private System.Windows.Forms.ComboBox comboBoxDifficulty;
		private System.Windows.Forms.Button buttonSave;
	}
}