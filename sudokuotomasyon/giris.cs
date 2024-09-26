using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sudokuotomasyon
{
	public partial class giris : Form
	{
		public giris()
		{
			InitializeComponent();
		}

		//veri tabanı yolu:"Data Source=DESKTOP-8EKVU1A\\MSSQLSERVER01;Initial Catalog=sudoku;Integrated Security=True"


		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8EKVU1A\\MSSQLSERVER01;Initial Catalog=sudoku;Integrated Security=True");
		private void button1_Click(object sender, EventArgs e)
		{
			
			
			oyun frm= new oyun();
			string kadi = kullanici_adi.Text;
			string sfre = sifre.Text;
			try
			{

				string sql = "Select * From kullanici where eposta=@kadi AND sifre=@sifre";

				SqlParameter prm1 = new SqlParameter("kadi", kadi.Trim());
				SqlParameter prm2 = new SqlParameter("sifre", sfre.Trim());

				SqlCommand komut = new SqlCommand(sql, baglanti);
				
				komut.Parameters.Add(prm1);
				komut.Parameters.Add(prm2);
				
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(komut);
				da.Fill(dt);

				if (dt.Rows.Count > 0)
				{
					frm.ShowDialog();
				}
				else
				{
					MessageBox.Show("şifre veya kullanıcı adı hatalı");
				}			
			}
			catch
			{
				MessageBox.Show("hata!!");
			}

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			kayit frm = new kayit();
			frm.ShowDialog();
		}

		private void giris_Load(object sender, EventArgs e)
		{
			baglanti.Open();
		}

		private void sifre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			sifremiunuttum frm = new sifremiunuttum();
			frm.ShowDialog();
		}
	}
}
