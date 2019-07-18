using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideMenuLogin
{
    public partial class Form1 : Form
    {
        private Form2 frm2;

        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            this.txtUsername.Clear();
            this.txtUsername.ForeColor = Color.FromArgb(77, 186, 206);
            this.picUsername.BackgroundImage = Properties.Resources.user2;
            this.panelUser.BackColor = Color.FromArgb(77, 186, 206);

            this.picPass.BackgroundImage = Properties.Resources.lock1;
            this.txtPass.ForeColor = Color.White;
            this.panelPass.BackColor = Color.White;

            this.picEmail.BackgroundImage = Properties.Resources.mail1;
            this.txtEmail.ForeColor = Color.White;
            this.panelEmail.BackColor = Color.White;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            this.txtPass.Clear();
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.ForeColor = Color.FromArgb(77, 186, 206);
            this.picPass.BackgroundImage = Properties.Resources.lock2;
            this.panelPass.BackColor = Color.FromArgb(77, 186, 206);

            this.picUsername.BackgroundImage = Properties.Resources.user1;
            this.txtUsername.ForeColor = Color.White;
            this.panelUser.BackColor = Color.White;

            this.picEmail.BackgroundImage = Properties.Resources.mail1;
            this.txtEmail.ForeColor = Color.White;
            this.panelEmail.BackColor = Color.White;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            this.txtEmail.Clear();
            this.txtEmail.ForeColor = Color.FromArgb(77, 186, 206);
            this.picEmail.BackgroundImage = Properties.Resources.mail2;
            this.panelEmail.BackColor = Color.FromArgb(77, 186, 206);

            this.picPass.BackgroundImage = Properties.Resources.lock1;
            this.txtPass.ForeColor = Color.White;
            this.panelPass.BackColor = Color.White;

            this.picUsername.BackgroundImage = Properties.Resources.user1;
            this.txtUsername.ForeColor = Color.White;
            this.panelUser.BackColor = Color.White;
        }

        private void picFacebook_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.frm2.Show();
            frm2.Left += 50;

            if(frm2.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frm2.Left -= 50;
            
            if(frm2.Left <= 525)
            {
                timer2.Stop();
            }
        }
    }
}
