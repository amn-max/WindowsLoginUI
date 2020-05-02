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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
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
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            UserPic.BackgroundImage = Properties.Resources.UserIcon30White;
            textBox1.ForeColor = Color.FromArgb(255, 255, 255);

            panel2.BackColor = Color.FromArgb(79, 184, 206);
            PasswordPic.BackgroundImage = Properties.Resources.PasswordAqua30;
            textBox2.ForeColor = Color.FromArgb(79, 184, 206);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
