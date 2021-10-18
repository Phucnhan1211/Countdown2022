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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = @"C:/Users/USER/source/repos/Countdown2022/PicMusic/nhactet.mp3";
            pictureBox1.Image = Image.FromFile("C:/Users/USER/source/repos/Countdown2022/PicMusic/phaohoa.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
