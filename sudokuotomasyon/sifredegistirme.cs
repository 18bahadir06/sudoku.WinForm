using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudokuotomasyon
{
	public partial class sifredegistirme : Form
	{
		public sifredegistirme()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8EKVU1A\\MSSQLSERVER01;Initial Catalog=sudoku;Integrated Security=True");
		
		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			if (textBox1.Text==textBox3.Text)
			{
				string veri = sifremiunuttum.kadiverisi;
				string sql1 = "UPDATE kullanici SET sifre=@sifre WHERE eposta=@kadi";

				SqlCommand komut2 = new SqlCommand(sql1, baglanti);
				SqlParameter prm1 = new SqlParameter("sifre",textBox1.Text);
				SqlParameter prm2 = new SqlParameter("kadi", veri);
				
				komut2.Parameters.Add(prm1);
				komut2.Parameters.Add(prm2);
				
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(komut2);
				da.Fill(dt);

				MessageBox.Show("şifreniz değiştirildi");
				this.Close();

			}
			else
			{
				MessageBox.Show("şifreler eşleşmşyor");
			}
			baglanti.Close();
		}

		private void sifredegistirme_Load(object sender, EventArgs e)
		{
			
		}
	}
}
