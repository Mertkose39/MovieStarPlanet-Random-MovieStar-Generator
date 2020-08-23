using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Random_Msp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(10000000, 39000000);
            label1.Text = sayi.ToString();
            var request = WebRequest.Create("https://snapshots.mspcdns.com/v1/MSP/tr/snapshot/moviestar/"+sayi+".jpg");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Width = 250;
            this.Height = 800;
            Random yeni = new Random();
            int sayi = yeni.Next(10000000, 39000000);
            label1.Text = sayi.ToString();
            var request = WebRequest.Create("https://snapshots.mspcdns.com/v1/MSP/DE/snapshot/fullSizeMoviestar/"+sayi+".jpg");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox2.Image = Bitmap.FromStream(stream);
            }
        }
    }
}
