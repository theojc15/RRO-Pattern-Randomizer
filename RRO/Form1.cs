using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RRO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "START";
            pictureBox1.Image = new Bitmap(RRO.Properties.Resources.track_sma_polos);
            pictureBox2.Image = new Bitmap(RRO.Properties.Resources.LOGO_RK_VECTOR__HI_RES__Preview);
            pictureBox3.Image = new Bitmap(RRO.Properties.Resources.RRO_Logo__1_);
            pictureBox4.Image = new Bitmap(RRO.Properties.Resources.Promo_Awal_Events__IG____RRO_22_1a);
            pictureBox5.Image = new Bitmap(RRO.Properties.Resources.logo_its_biru_transparan);
        }

        List<int> ban = new List<int>();
        int value;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            value = rnd.Next(1, 6);
            if (value == 1)
            {
                pictureBox1.Image = new Bitmap(RRO.Properties.Resources.pola_SMA_1);
            }
            else if (value == 2)
            {
                pictureBox1.Image = new Bitmap(RRO.Properties.Resources.pola_SMA_2);
            }
            else if (value == 3)
            {
                pictureBox1.Image = new Bitmap(RRO.Properties.Resources.pola_SMA_3);
            }
            else if (value == 4)
            {
                pictureBox1.Image = new Bitmap(RRO.Properties.Resources.pola_SMA_4);
            }
            else if (value == 5)
            {
                pictureBox1.Image = new Bitmap(RRO.Properties.Resources.pola_SMA_5);
            }
            else
            {
                pictureBox1.Image = new Bitmap(RRO.Properties.Resources.track_sma_polos);
            }


        }

        
        int start = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (start == 0)
            {
                timer1.Enabled = true;
                start = 1;
                button1.Text = "STOP";
            }
            else
            {
                timer1.Enabled = false;
                start = 0;
                while (ban.Contains(value)) 
                {
                    Random rnd = new Random();
                    value = rnd.Next(1, 6);
                    if (value == 1)
                    {
                        pictureBox1.Image = new Bitmap(RRO.Properties.Resources.pola_SMA_1);
                    }
                    else if (value == 2)
                    {
                        pictureBox1.Image = new Bitmap(RRO.Properties.Resources.pola_SMA_2);
                    }
                    else if (value == 3)
                    {
                        pictureBox1.Image = new Bitmap(RRO.Properties.Resources.pola_SMA_3);
                    }
                    else if (value == 4)
                    {
                        pictureBox1.Image = new Bitmap(RRO.Properties.Resources.pola_SMA_4);
                    }
                    else if (value == 5)
                    {
                        pictureBox1.Image = new Bitmap(RRO.Properties.Resources.pola_SMA_5);
                    }
                    else
                    {
                        pictureBox1.Image = new Bitmap(RRO.Properties.Resources.track_sma_polos);
                    }
                } 
                ban.Add(value);
                button1.Text = "START";
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point((this.Width / 2) - (pictureBox1.Width / 2), (this.Height / 2) - (pictureBox1.Height / 2));
        }
    }
}
