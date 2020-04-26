using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Data
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

       
        Form2 frm2 = new Form2();

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            panel3.BackColor = Color.FromArgb(79, 184, 206);
            emailpic.BackgroundImage = Properties.Resources.emailAqua30;
            textBox3.ForeColor = Color.FromArgb(79, 184, 206);

            panel1.BackColor = Color.FromArgb(255,255,255);
            UserPic.BackgroundImage = Properties.Resources.UserIcon30White;
            textBox1.ForeColor = Color.FromArgb(255,255,255);

            panel2.BackColor = Color.FromArgb(255, 255, 255);
            PasswordPic.BackgroundImage = Properties.Resources.PasswordWhite30;
            textBox2.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel3.BackColor = Color.FromArgb(255, 255, 255);
            emailpic.BackgroundImage = Properties.Resources.emailWhite30;
            textBox3.ForeColor = Color.FromArgb(255, 255, 255);

            panel1.BackColor = Color.FromArgb(79, 184, 206);
            UserPic.BackgroundImage = Properties.Resources.UserIcon30Aqua;
            textBox1.ForeColor = Color.FromArgb(79, 184, 206);

            panel2.BackColor = Color.FromArgb(255, 255, 255);
            PasswordPic.BackgroundImage = Properties.Resources.PasswordWhite30;
            textBox2.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            panel3.BackColor = Color.FromArgb(255, 255, 255);
            emailpic.BackgroundImage = Properties.Resources.emailWhite30;
            textBox3.ForeColor = Color.FromArgb(255, 255, 255);

            panel1.BackColor = Color.FromArgb(255, 255, 255);
            UserPic.BackgroundImage = Properties.Resources.UserIcon30White;
            textBox1.ForeColor = Color.FromArgb(255, 255, 255);

            panel2.BackColor = Color.FromArgb(79, 184, 206);
            PasswordPic.BackgroundImage = Properties.Resources.PasswordAqua30;
            textBox2.ForeColor = Color.FromArgb(79, 184, 206);
        }

        private void FacebookPic_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          //  label2.Text = frm2.Left.ToString();
            frm2.Left += 10;
            if(frm2.Left>=830)
            {
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = false;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          //  label2.Text = frm2.Left.ToString();
            frm2.Left -= 10;
            if(frm2.Left<=712)
            {
                timer2.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm2.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
