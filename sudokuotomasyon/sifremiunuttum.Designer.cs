namespace sudokuotomasyon
{
	partial class sifremiunuttum
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
			this.txteposta = new System.Windows.Forms.TextBox();
			this.txtad = new System.Windows.Forms.TextBox();
			this.txtsoyad = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txteposta
			// 
			this.txteposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.txteposta.Location = new System.Drawing.Point(98, 116);
			this.txteposta.Name = "txteposta";
			this.txteposta.Size = new System.Drawing.Size(100, 26);
			this.txteposta.TabIndex = 0;
			// 
			// txtad
			// 
			this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.txtad.Location = new System.Drawing.Point(98, 148);
			this.txtad.Name = "txtad";
			this.txtad.Size = new System.Drawing.Size(100, 26);
			this.txtad.TabIndex = 1;
			// 
			// txtsoyad
			// 
			this.txtsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.txtsoyad.Location = new System.Drawing.Point(98, 180);
			this.txtsoyad.Name = "txtsoyad";
			this.txtsoyad.Size = new System.Drawing.Size(100, 26);
			this.txtsoyad.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(29, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "eposta";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(29, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "soyad";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(29, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ad";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(28, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(202, 28);
			this.label4.TabIndex = 6;
			this.label4.Text = "Kullanıcı doğrulama";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(36, 258);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(171, 42);
			this.button1.TabIndex = 7;
			this.button1.Text = "Kullanıcı Doğrulama";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// sifremiunuttum
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(251, 343);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtsoyad);
			this.Controls.Add(this.txtad);
			this.Controls.Add(this.txteposta);
			this.Name = "sifremiunuttum";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "sifremiunuttum";
			this.Load += new System.EventHandler(this.sifremiunuttum_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txteposta;
		private System.Windows.Forms.TextBox txtad;
		private System.Windows.Forms.TextBox txtsoyad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
	}
}