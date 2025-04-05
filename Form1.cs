using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jyuici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int birinjiatuzaklik, ikinjiatuzaklyk, ucunjiatuzaklyk;
        Random rastgele = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            birinjiatuzaklik = pictureBox1.Left;
            ikinjiatuzaklyk = pictureBox2.Left;
            ucunjiatuzaklyk = pictureBox3.Left;

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinjiatgen = pictureBox1.Width;
            int ikinjiatgen = pictureBox2.Width;
            int ucatgen = pictureBox3.Width;

            int bitishuzaklik = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 17);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 10);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 18);
            if (birinjiatgen + pictureBox1.Left >= bitishuzaklik)
            {
                timer1.Enabled = false;
                MessageBox.Show("ÝEŇIJI 1-NJI IT ");
            }
            if (ikinjiatgen + pictureBox2.Left >= bitishuzaklik)
            {
                timer1.Enabled = false;
                MessageBox.Show("ÝEŇIJI 2-NJI IT");
            }
            if (ucatgen+ pictureBox3.Left >= bitishuzaklik)
          {
                timer1.Enabled = false;
                MessageBox.Show("ÝEŇIJI 3-NJI IT");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
