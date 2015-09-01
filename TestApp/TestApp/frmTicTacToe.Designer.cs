namespace TestApp
{
	partial class frmTicTacToe
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.bt00 = new System.Windows.Forms.Button();
			this.bt10 = new System.Windows.Forms.Button();
			this.bt20 = new System.Windows.Forms.Button();
			this.bt01 = new System.Windows.Forms.Button();
			this.bt11 = new System.Windows.Forms.Button();
			this.bt21 = new System.Windows.Forms.Button();
			this.bt02 = new System.Windows.Forms.Button();
			this.bt12 = new System.Windows.Forms.Button();
			this.bt22 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bt00
			// 
			this.bt00.Location = new System.Drawing.Point(12, 12);
			this.bt00.Name = "bt00";
			this.bt00.Size = new System.Drawing.Size(75, 75);
			this.bt00.TabIndex = 0;
			this.bt00.UseVisualStyleBackColor = true;
			// 
			// bt10
			// 
			this.bt10.Location = new System.Drawing.Point(93, 12);
			this.bt10.Name = "bt10";
			this.bt10.Size = new System.Drawing.Size(75, 75);
			this.bt10.TabIndex = 1;
			this.bt10.UseVisualStyleBackColor = true;
			// 
			// bt20
			// 
			this.bt20.Location = new System.Drawing.Point(174, 12);
			this.bt20.Name = "bt20";
			this.bt20.Size = new System.Drawing.Size(75, 75);
			this.bt20.TabIndex = 2;
			this.bt20.UseVisualStyleBackColor = true;
			// 
			// bt01
			// 
			this.bt01.Location = new System.Drawing.Point(12, 93);
			this.bt01.Name = "bt01";
			this.bt01.Size = new System.Drawing.Size(75, 75);
			this.bt01.TabIndex = 3;
			this.bt01.UseVisualStyleBackColor = true;
			// 
			// bt11
			// 
			this.bt11.Location = new System.Drawing.Point(93, 93);
			this.bt11.Name = "bt11";
			this.bt11.Size = new System.Drawing.Size(75, 75);
			this.bt11.TabIndex = 4;
			this.bt11.UseVisualStyleBackColor = true;
			// 
			// bt21
			// 
			this.bt21.Location = new System.Drawing.Point(174, 93);
			this.bt21.Name = "bt21";
			this.bt21.Size = new System.Drawing.Size(75, 75);
			this.bt21.TabIndex = 5;
			this.bt21.UseVisualStyleBackColor = true;
			// 
			// bt02
			// 
			this.bt02.Location = new System.Drawing.Point(12, 174);
			this.bt02.Name = "bt02";
			this.bt02.Size = new System.Drawing.Size(75, 75);
			this.bt02.TabIndex = 6;
			this.bt02.UseVisualStyleBackColor = true;
			// 
			// bt12
			// 
			this.bt12.Location = new System.Drawing.Point(93, 174);
			this.bt12.Name = "bt12";
			this.bt12.Size = new System.Drawing.Size(75, 75);
			this.bt12.TabIndex = 7;
			this.bt12.UseVisualStyleBackColor = true;
			// 
			// bt22
			// 
			this.bt22.Location = new System.Drawing.Point(174, 174);
			this.bt22.Name = "bt22";
			this.bt22.Size = new System.Drawing.Size(75, 75);
			this.bt22.TabIndex = 8;
			this.bt22.UseVisualStyleBackColor = true;
			// 
			// frmTicTacToe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 262);
			this.Controls.Add(this.bt22);
			this.Controls.Add(this.bt12);
			this.Controls.Add(this.bt02);
			this.Controls.Add(this.bt21);
			this.Controls.Add(this.bt11);
			this.Controls.Add(this.bt01);
			this.Controls.Add(this.bt20);
			this.Controls.Add(this.bt10);
			this.Controls.Add(this.bt00);
			this.Name = "frmTicTacToe";
			this.Text = "TicTacToe";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bt00;
		private System.Windows.Forms.Button bt10;
		private System.Windows.Forms.Button bt20;
		private System.Windows.Forms.Button bt01;
		private System.Windows.Forms.Button bt11;
		private System.Windows.Forms.Button bt21;
		private System.Windows.Forms.Button bt02;
		private System.Windows.Forms.Button bt12;
		private System.Windows.Forms.Button bt22;
	}
}

