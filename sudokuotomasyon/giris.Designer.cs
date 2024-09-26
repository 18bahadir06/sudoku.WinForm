namespace sudokuotomasyon
{
	partial class giris
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
			this.kullanici_adi = new System.Windows.Forms.TextBox();
			this.sifre = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// kullanici_adi
			// 
			this.kullanici_adi.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.kullanici_adi.Location = new System.Drawing.Point(119, 90);
			this.kullanici_adi.Name = "kullanici_adi";
			this.kullanici_adi.Size = new System.Drawing.Size(125, 27);
			this.kullanici_adi.TabIndex = 0;
			// 
			// sifre
			// 
			this.sifre.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.sifre.Location = new System.Drawing.Point(119, 141);
			this.sifre.Name = "sifre";
			this.sifre.PasswordChar = '*';
			this.sifre.Size = new System.Drawing.Size(125, 27);
			this.sifre.TabIndex = 1;
			this.sifre.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.sifre_MaskInputRejected);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(12, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Kullanıcı Adı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(30, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Şifre";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(128, 194);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 35);
			this.button1.TabIndex = 4;
			this.button1.Text = "GİRİŞ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label3.Location = new System.Drawing.Point(12, 295);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(245, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "yoksa hala hesabınız yokmu hemen ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(235, 249);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(10, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = ".";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.linkLabel1.Location = new System.Drawing.Point(255, 295);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(69, 20);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "kaydolun";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(128, 235);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 30);
			this.button2.TabIndex = 8;
			this.button2.Text = "şifermi unuttum";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// giris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 344);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sifre);
			this.Controls.Add(this.kullanici_adi);
			this.Name = "giris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "giris";
			this.Load += new System.EventHandler(this.giris_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox kullanici_adi;
		private System.Windows.Forms.MaskedTextBox sifre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button button2;
	}
}