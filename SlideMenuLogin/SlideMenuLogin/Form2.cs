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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername2_Click(object sender, EventArgs e)
        {
            this.txtUsername2.Clear();
            this.txtUsername2.ForeColor = Color.FromArgb(77, 186, 206);
            this.picUsername2.BackgroundImage = Properties.Resources.user2;
            this.panelUser.BackColor = Color.FromArgb(77, 186, 206);

            this.picPass2.BackgroundImage = Properties.Resources.lock1;
            this.txtPass2.ForeColor = Color.White;
            this.panelPass.BackColor = Color.White;
        }

        private void txtPass2_Click(object sender, EventArgs e)
        {
            this.txtPass2.Clear();
            this.txtPass2.UseSystemPasswordChar = true;
            this.txtPass2.ForeColor = Color.FromArgb(77, 186, 206);
            this.picPass2.BackgroundImage = Properties.Resources.lock2;
            this.panelPass.BackColor = Color.FromArgb(77, 186, 206);

            this.picUsername2.BackgroundImage = Properties.Resources.user1;
            this.txtUsername2.ForeColor = Color.White;
            this.panelUser.BackColor = Color.White;
        }
    }
}
