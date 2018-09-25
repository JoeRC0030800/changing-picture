using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changing_picture
{
    public partial class Form1 : Form
    {
        private Image dog;
        private Image Dog2;

        public Form1()
        {
            InitializeComponent();
            dog = Properties.Resources.dog;
            Dog2 = Properties.Resources.Boxer_On_White_03_400x267;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == dog) ;
            {
                pictureBox1.Image = Dog2;
            }
            }
        }
    }
}
