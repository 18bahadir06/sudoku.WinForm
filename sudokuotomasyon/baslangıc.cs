using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudokuotomasyon
{
	public partial class baslangıc : Form
	{
		public baslangıc()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			giris frm= new giris();
			frm.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			KVK form=new KVK();
			form.ShowDialog();
		}

		private void baslangıc_Load(object sender, EventArgs e)
		{

		}
	}
}
