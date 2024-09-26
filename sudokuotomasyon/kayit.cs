using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudokuotomasyon
{
	public partial class kayit : Form
	{
		public kayit()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8EKVU1A\\MSSQLSERVER01;Initial Catalog=sudoku;Integrated Security=True");

		
		private void kayit_Load(object sender, EventArgs e)
		{
			baglanti.Open();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			KVK frm= new KVK();
			frm.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bool control1 = false;
			bool control2 = false;
			bool control3 = false;
			bool control4 = false;
			bool control5 = false;
			//bool control6 = false;

			string ad = txtad.Text;
			string soyad = txtsoyad.Text;
			string eposta = txtkadi.Text;
			string sifre = txtsifre.Text;
			string sifre2 = txtsifre2.Text;




			if (ad.Length < 1)
			{
				MessageBox.Show("lütfen adınızı girdiğnizden emin olunuz");
			}
			else
			{
				control1= true;
			}

			if (soyad.Length < 1)
			{
				MessageBox.Show("lütfen soyadınızı girdiğnizden emin olunuz");
			}
			else
			{
				control2= true;
			}

			if (eposta.EndsWith(".com") != true)
			{
				MessageBox.Show("lütfen maili düzgün giriniz.");
			}
			else
			{
				control3= true;
			}
			if (sifre != sifre2 && sifre=="")
			{
				MessageBox.Show("şifreler uyuşmuyor");
			}
			else
			{
				control4= true;
			}
			if (checkBox1.Checked == false)
			{
				MessageBox.Show("kullanım ve gizlilik sözleşmesini kabul ediniz");
			}
			else
			{
				control5= true;
			}



			//string sql = "Select * From kullanici where eposta=@kadi";
			//SqlParameter prm6 = new SqlParameter("kadi",eposta.Trim());


			//SqlCommand komut = new SqlCommand(prm6, baglanti);
			//SqlDataReader oku = komut.ExecuteReader();

			//if (oku.Read())
			//{
			//	MessageBox.Show("bu kullanıcı adı kullanılıyor lütfen başka kullanıcı adı giriniz");
			//}
			//else
			//{
			//	control6 = true;
			//}

			if (control1==true && control2==true 
				&& control3==true && control4==true 
				&& control5==true )
			{
				string sorgu = "insert into kullanici(ad,soyad,eposta,sifre) values(@adi,@soyadi,@kadi,@sifresi)";


				SqlCommand ekle = new SqlCommand(sorgu,baglanti);

				SqlParameter prm1 = new SqlParameter("adi", ad);
				SqlParameter prm2 = new SqlParameter("soyadi", soyad);
				SqlParameter prm3 = new SqlParameter("kadi", eposta);
				SqlParameter prm4 = new SqlParameter("sifresi", sifre);

				ekle.Parameters.Add(prm1);
				ekle.Parameters.Add(prm2);
				ekle.Parameters.Add(prm3);
				ekle.Parameters.Add(prm4);



				ekle.ExecuteNonQuery();
				MessageBox.Show("kayıt oldunuz");

				this.Close();
			}
			else
			{
				MessageBox.Show("girmedi");
			}
			



		}
	}
}
