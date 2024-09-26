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
	public partial class oyun : Form
	{
		public oyun()
		{
			InitializeComponent();
		}

		private void oyun_Load(object sender, EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;


			int[] s1 = {
				6,1,2,5,8,3,7,4,9,
				5,9,7,4,2,6,1,3,8,
				4,3,8,9,7,1,5,2,6,
				2,6,1,8,3,5,9,7,4,
				3,4,9,1,6,7,2,8,5,
				8,7,5,2,9,4,3,6,1,
				7,5,6,3,1,8,4,9,2,
				1,2,3,6,4,9,8,5,7,
				9,8,4,7,5,2,6,1,3
			};

			int[] s2 = {
				2,6,5,8,4,1,3,9,7,
				3,9,8,7,6,5,1,4,2,
				4,7,1,2,3,9,6,8,5,
				6,2,4,5,1,8,7,3,9,
				9,5,3,4,7,6,2,1,8,
				8,1,7,9,2,3,4,5,6,
				1,3,9,6,5,2,8,7,4,
				5,4,6,3,8,7,9,2,1,
				7,8,2,1,9,4,5,6,3
			};
			int[] s3 =
			{
				7,6,4,9,5,1,8,3,2,
				3,8,9,2,6,7,5,1,4,
				1,2,5,8,4,3,7,9,6,
				5,3,7,6,8,9,2,4,1,
				9,1,6,4,7,2,3,8,5,
				8,4,2,1,3,5,6,7,9,
				6,7,1,3,2,4,9,5,8,
				2,9,3,5,1,8,4,6,7,
				4,5,8,7,9,6,1,2,3,
			};
			int[] s4 =
			{
				8,3,4,9,1,6,5,2,7,
				7,9,2,8,3,5,4,1,6,
				6,5,1,7,4,2,9,3,8,
				9,7,5,1,2,3,6,8,4,
				2,8,6,4,7,9,3,5,1,
				4,1,3,6,5,8,7,9,2,
				1,6,9,3,8,4,2,7,5,
				3,2,7,5,6,1,8,4,9,
				5,4,8,2,9,7,1,6,3,
			};
			int[] s5 =
			{
				7,9,5,3,2,8,6,1,4,
				6,8,2,4,5,1,7,3,9,
				4,3,1,7,9,6,2,5,8,
				9,2,7,6,1,5,8,4,3,
				3,1,8,9,4,2,5,7,6,
				5,4,6,8,7,3,1,9,2,
				1,6,4,5,8,9,3,2,7,
				2,7,3,1,6,4,9,8,5,
				8,5,9,2,3,7,4,6,1,
			};
			int[] s6 =
			{
				3,1,4,2,5,6,9,8,7,
				8,9,6,7,4,3,1,5,2,
				7,2,5,8,9,1,3,6,4,
				2,4,7,9,6,8,5,1,3,
				6,3,1,4,2,5,7,9,8,
				5,8,9,3,1,7,4,2,6,
				9,6,8,1,7,4,2,3,5,
				4,5,2,6,3,9,8,7,1,
				1,7,3,5,8,2,6,4,9
			};
			int[] s7 =
			{
				5,6,3,7,9,2,4,8,1,
				8,9,4,5,6,1,2,7,3,
				1,2,7,3,4,8,5,9,6,
				9,4,6,8,5,3,7,1,2,
				3,1,2,6,7,9,8,4,5,
				7,5,8,2,1,4,6,3,9,
				4,7,9,1,2,5,3,6,8,
				6,8,5,9,3,7,1,2,4,
				2,3,1,4,8,6,9,5,7
			};










			int x = 0;
			int y = 0;
			int sayac = 0;


			//for (int d = 0; d < 3; d++)
			//{
			//	Label r = new Label();
			//	r.Location=new Point(100,100);
			//	r.BackColor= Color.Red;
			//	r.ForeColor= Color.Red;
			//	r.Size = new Size(500, 500);
			//	Controls.Add(r);
			//}
			ArrayList dizi = new ArrayList();
			Random random = new Random();
			for (int a = 0; a < 31; a++)
			{
				int sayi1 = random.Next(0, 9);
				int sayi2 = random.Next(0, 9);
				dizi.Clear();
				dizi.Add(sayi1);
				dizi.Add(sayi2);
				TextBox txt = new TextBox();
				int x1 = 75 * sayi1;
				int y1 = 75 * sayi2;
				//txt.Width= x1;
				//txt.Height= y1;
				txt.Location = new Point(x1, y1);
				txt.Size = new Size(70, 70);
				txt.BackColor = Color.White;
				txt.ForeColor = Color.Black;
				txt.Font = new Font("Newtime", 42, FontStyle.Bold);
				Controls.Add(txt);
				txt.TextChanged += Txt_TextChanged;

				if (txt.Text == s1[sayi1 * sayi2].ToString())
				{
					MessageBox.Show("merhaba");
				}
			}

			int k=random.Next(1,8);
			int[] sayideger = { };

			switch (k)
			{
				case 1:
					sayideger = s1;
					break;
				case 2:
					sayideger = s2;
					break;
				case 3:
					sayideger = s3;
					break;
				case 4:
					sayideger = s4;
					break;
				case 5:
					sayideger = s5;
					break;
				case 6:
					sayideger = s6;
					break;
				case 7:
					sayideger = s7;
					break;
			}


			for (int c = 0; c < 9; c++)
			{

				x = 0;

				for (int i = 0; i < 9; i++)
				{
					Label a = new Label();
					a.Text = sayideger[sayac].ToString();
					//a.Width = 10;
					//a.Height = 10;

					a.Location = new Point(x, y);
					a.Size = new Size(70, 70);

					a.BackColor = Color.Black;
					a.ForeColor = Color.White;

					a.Font = new Font("Newtime", 25, FontStyle.Bold);
					Controls.Add(a);
					x = x + 75;
					sayac++;

				}
				y = y + 75;
			}
		}

		private void Txt_TextChanged(object sender, EventArgs e)
		{
			TextBox Txt = (TextBox)(sender);
			if (!string.IsNullOrEmpty(Txt.Text))
			{
				Txt.Visible = false;
			}
		}
	}
}
