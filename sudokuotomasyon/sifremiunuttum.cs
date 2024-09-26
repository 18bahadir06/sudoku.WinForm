using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace sudokuotomasyon
{
	public partial class sifremiunuttum : Form
	{
		public sifremiunuttum()
		{
			InitializeComponent();
		}

		private void sifremiunuttum_Load(object sender, EventArgs e)
		{
			baglanti.Open();

		}
		public static string kadiverisi ;

		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8EKVU1A\\MSSQLSERVER01;Initial Catalog=sudoku;Integrated Security=True");
		private void button1_Click(object sender, EventArgs e)
		{
			sifredegistirme frm = new sifredegistirme();
			string adi = txtad.Text;
			string soyadi = txtsoyad.Text;
			string eposta = txteposta.Text;

			//string sorgu = "select ad from kullanici";
			//SqlCommand komut2 = new SqlCommand(sorgu,baglanti);
			//SqlDataReader a=komut2.ExecuteReader();

			//while (a.Read())
			//{
			//	MessageBox.Show(a["ad"].ToString());
			//}

			string sql = "Select * From kullanici where eposta=@kadi AND ad=@ad AND soyad=@soyad";
			//string sql1 = "select id from kullanici where eposta=@kadi";
			SqlParameter prm1 = new SqlParameter("kadi",eposta);
			SqlParameter prm2 = new SqlParameter("ad", adi);
			SqlParameter prm3 = new SqlParameter("soyad", soyadi);
			
			SqlCommand komut = new SqlCommand(sql, baglanti);
			//SqlCommand komut2 = new SqlCommand(sql1, baglanti);

			//komut2.Parameters.Add(prm1);

			komut.Parameters.Add(prm1);
			komut.Parameters.Add(prm2);
			komut.Parameters.Add(prm3);
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(komut);
			da.Fill(dt);
			
			kadiverisi = eposta;
			
			if (dt.Rows.Count > 0)
			{
				frm.ShowDialog();
				this.Close();
			}
			else
			{
				MessageBox.Show("hatalı");
			}


			

			//string sorgu = "UPDATE kullanici SET sifre=@sifre WHERE Id=@ıd";
		}
	}
}
