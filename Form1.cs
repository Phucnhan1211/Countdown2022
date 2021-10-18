using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdown2022
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Load += Form1_Load;
		}
		Timer t;
		DateTime endTime = new DateTime(2022, 02, 01, 00, 00, 00);

		 void Form1_Load(object sender, EventArgs e)
		{
			t = new Timer();
			t.Interval = 500;
			t.Tick += t_Tick;

			TimeSpan ts = endTime.Subtract(DateTime.Now);
			label3.Text = ts.ToString("dd' Ngày 'hh' Giờ 'mm' Phút 'ss' Giây'");

			t.Start();
		}

		 void t_Tick(object sender, EventArgs e)
		{
			TimeSpan ts = endTime.Subtract(DateTime.Now);
			label3.Text = ts.ToString("dd' Ngày 'hh' Giờ 'mm' Phút 'ss' Giây'");
			if (ts.TotalSeconds <= 0)
			{
				t.Stop();
				var f = new Form2();
				f.Show();
			}
		}
	}
}
