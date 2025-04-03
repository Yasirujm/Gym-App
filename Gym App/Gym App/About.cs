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
    public partial class About : MaterialForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void find_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/Q+Gym/@6.9378237,79.8580765,17z/data=!3m1!4b1!4m6!3m5!1s0x3ae259d56de90f5f:0xff57549e4a85234a!8m2!3d6.9378184!4d79.8606514!16s%2Fg%2F11jq_gm35q?entry=ttu");
        }

        private void bck_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
