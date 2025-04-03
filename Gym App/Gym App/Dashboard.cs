using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_App
{
    public partial class Dashboard : MaterialForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void member_Click(object sender, EventArgs e)
        {
            this.Hide();//to hide dashboard form
            Memberships MembershipForm = new Memberships();
            MembershipForm.FormClosed += (s, args) => { this.Show(); };// to bring back dashboard form
            MembershipForm.Show();
        }

        private void ext2_Click(object sender, EventArgs e)
        {
            Application.Exit();// exit the whole app
        }

        private void lgout_Click(object sender, EventArgs e)
        {
            this.Close();// close app
        }

        private void shop_Click(object sender, EventArgs e)
        {
            this.Hide();//to hide dashboard form
            Shop ShopForm = new Shop();
            ShopForm.FormClosed += (s, args) => { this.Show(); };// to bring back dashboard form
            ShopForm.Show();
        }

        private void faqs_Click(object sender, EventArgs e)
        {
            this.Hide();//to hide dashboard form
            FAQs FAQForm = new FAQs();
            FAQForm.FormClosed += (s, args) => { this.Show(); };// to bring back dashboard form
            FAQForm.Show();
        }

        private void abt_Click(object sender, EventArgs e)
        {
            this.Hide();//to hide dashboard form
            About AboutForm = new About();
            AboutForm.FormClosed += (s, args) => { this.Show(); };// to bring back dashboard form
            AboutForm.Show();
        }
    }
}