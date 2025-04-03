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
    public partial class Memberships : MaterialForm
    {
        public Memberships()
        {
            InitializeComponent();
        }

        private void purch1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment_Portal PaymentForm = new Payment_Portal();
            PaymentForm.FormClosed += (s, args) => this.Show();
            PaymentForm.Show();
        }

        private void purch2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment_Portal PaymentForm = new Payment_Portal();
            PaymentForm.FormClosed += (s, args) => this.Show();
            PaymentForm.Show();
        }

        private void bck_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
